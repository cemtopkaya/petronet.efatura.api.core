using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using petronet.efatura.api.core.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace petronet.efatura.api.core {
    public class Startup {
        #region Props & Fields
        IOrderedEnumerable<string> _versions;
        private IOrderedEnumerable<string> Versions {
            get {
                if (_versions == null) {
                    var types = GetType().Assembly.GetTypes();
                    var versionedControllers = types.Where(t => typeof(ControllerBase).IsAssignableFrom(t));

                    _versions = versionedControllers
                    .Select(ctrl => ctrl.GetCustomAttributes<ApiVersionAttribute>(false))
                    .SelectMany(f => f)
                    .SelectMany(v => v.Versions)
                    .Select(f => f.ToString())
                    .Distinct()
                    .OrderBy(s => s);
                }

                return _versions;
            }
        }

        public IConfiguration Configuration { get; }
        #endregion

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers()
                    .AddXmlSerializerFormatters()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            #region Api Versiyonlama
            services.AddApiVersioning(v => {
                v.ReportApiVersions = true;
                v.AssumeDefaultVersionWhenUnspecified = true;
                v.DefaultApiVersion = new ApiVersion(1, 0);
            });
            #endregion
            
            #region Swagger 2.0 - OpenApi 3.0
            services.AddSwaggerGen(c => {
                #region SwaggerDocument Nesnelerini Yarat
                foreach (var version in Versions) {
                    var swaggerDocument = new OpenApiInfo {
                        Version = version,
                        Title = "EFatura WEB API",
                        Description = "Backoffice uygulamasý için E-Fatura WEB API",
                        TermsOfService = new Uri("https://petronetotomasyon.com/terms"),
                        Contact = new OpenApiContact {
                            Name = "Ahmet Coþkun",
                            Email = "a.coskun@petronetotomasyon.com",
                            Url = new Uri("https://petronetotomasyon.com"),
                        }
                    };
                    c.SwaggerDoc(version, swaggerDocument);
                }
                #endregion

                #region SwaggerDocument nesneleriyle Controller tiplerini eþleþtir.
                c.DocInclusionPredicate((docName, apiDesc) => {

                    if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo)) return false;

                    var versions = methodInfo.DeclaringType // Api içinde tanýmlý tipleri getir
                        .GetCustomAttributes(true) // Niteliklerini çek
                        .OfType<ApiVersionAttribute>() // ApiVersionAttribute tipindeki nitelikleri süz
                        .SelectMany(attr => attr.Versions); // ApiVersion niteliðindeki Versions özelliklerini flat dön

                    return versions.Any(v => v.ToString() == docName);
                });
                #endregion

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            #endregion
            
            #region Automapper Conf.
            var mappingConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new Configuration.Mappings.Uyumsoft());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

            #region Swagger için JSON Web Token Ayarlarý
            services.AddSwaggerGen(c => {
                var securityScheme = new OpenApiSecurityScheme {
                    Reference = new OpenApiReference {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Description = "JWT Token gerekiyor!",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                };
                c.AddSecurityDefinition("Bearer", securityScheme);

                // Security Requirement
                c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                        { securityScheme, Array.Empty<string>() }
                    });
            });
            #endregion

            #region JSON Web Token ayarlarý
            var jwtSettings = new TokenSettings();
            Configuration.Bind("jwtSettings", jwtSettings);

            services.AddAuthentication(opt => {
                /**
                 * Bir Controller niteliðinde [Authorize] kullandýðýnýzda, 
                 * ilk yetkilendirme sistemine varsayýlan olarak baðlamasý için
                 */
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                /**
                 * Eðer `services.AddIdentity>()` ile bir kimlik kullanýyorsanýz, 
                 * DefaultChallengeScheme sizi bir giriþ sayfasýna yönlendirmeye çalýþacaktýr, 
                 * eðer bir kimlik mevcut deðilse, 404 döner. Eðer var ve yetkisiz ise 401 "yetkisiz eriþim" hatasý alacaksýnýz.
                 */
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt => {
                TokenValidationParameters param;

                param = new TokenValidationParameters {
                    // Require Bilgileri yoksa geçersiz kýl!
                    RequireSignedTokens = true,
                    RequireExpirationTime = true,

                    // Neleri doðrulamasýný istiyorsak
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,

                    // Beklediðimiz Issuer ve Audience bilgilerini veririz
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,

                    /**
                     * Gelen token bilgisiyle, gönderdiðimizin imzasý ayný mý diye 
                     * geleni imzalayacak ve kontrol edeceðiz
                     */
                    IssuerSigningKey = jwtSettings.IssuerSigningKey,
                };

                opt.RequireHttpsMetadata = false; // Production ortamý ise true yani https olsun diyebiliriz
                opt.SaveToken = true;
                opt.TokenValidationParameters = param;

                opt.Events = new JwtBearerEvents() {
                    OnAuthenticationFailed = context => {
                        context.Response.StatusCode = 401;
                        context.Response.ContentType = "application/json; charset=utf-8";
                        var message = context.Exception.ToString();
                        var result = JsonConvert.SerializeObject(new { message });

                        Console.WriteLine("HATA >>>> " + message);
                        return context.Response.WriteAsync(result);
                    }
                };
            });
            #endregion

            services.AddOptions();

            #region Integrator's Configuration Injection
            var section = Configuration.GetSection("UyumsoftEInvoiceTestServiceSettings");
            services.Configure<WCFServiceSettings>(section); 
            #endregion
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            #region Swagger 
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => {
                foreach (var v in Versions) {
                    // Her versiyon için bir uç nokta yaratmasýný Swagger'a söylüyoruz
                    c.SwaggerEndpoint($"/swagger/{v}/swagger.json", $"API Þablonu v{v}");
                }
            });
            #endregion

            #region CORS - Cross Origin Resource Sharing Ayarlarý
            /* AllowAnyOrigin: Herhangi bir domain adýndan
             * AllowAnyMethod: Herhangi bir HTTP metoduyla (GET, POST, PATH vs)
             * AllowAnyHeader: Herhangi bir HTTP Header bilgisiyle 
             * Yani herkesle her durumda her þeyi paylaþ
             */
            app.UseCors(confPolicy => {
                confPolicy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            #endregion

            app.UseRouting();

            #region JSON Web Token
            /* app.UseAuthorization() metodu app.UseRouting() ile app.UseEndpoints() arasýnda olmalý!
             * 
             * Configure your application startup by adding app.UseAuthorization() 
             * inside the call to Configure(..) in the application startup code. 
             * The call to app.UseAuthorization() must appear between app.UseRouting() and app.UseEndpoints(...)
             */
            app.UseAuthentication();
            app.UseAuthorization();
            #endregion

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
