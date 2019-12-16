using System.Linq;
using AutoMapper;
using UBL = petronet.efatura.api.core.Model.UBL;

namespace petronet.efatura.api.core.Configuration.Mappings {

    public class Uyumsoft : Profile {
        public Uyumsoft()
        {
            var types = GetType().Assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.Namespace!=null && type.Namespace.Equals("petronet.efatura.api.core.Model.UBL"))
                {
                    var source = type;
                    var destination = types.FirstOrDefault(t => t.Name == type.Name && t.Namespace.Equals("uyumsoft"));
                    if (destination != null)
                    {
                        CreateMap(source,destination);
                    }
                }
            }


            CreateMap<UBL.InvoiceType, uyumsoft.InvoiceType>();
            CreateMap<uyumsoft.InvoiceType, UBL.InvoiceType>();

            CreateMap<UBL.UBLExtensionType, uyumsoft.UBLExtensionType>();
            CreateMap<uyumsoft.UBLExtensionType,UBL.UBLExtensionType>();

            CreateMap<UBL.ExtensionContentType, uyumsoft.ExtensionContentType>();
            CreateMap<uyumsoft.ExtensionContentType, UBL.ExtensionContentType>();

            CreateMap<UBL.SignatureType, uyumsoft.SignatureType>();
            CreateMap<uyumsoft.SignatureType, UBL.SignatureType>();
            
            CreateMap<uyumsoft.SignatureValueType, UBL.SignatureValueType>();
            CreateMap<UBL.SignatureValueType, uyumsoft.SignatureValueType>();
            
            CreateMap<uyumsoft.ObjectType, UBL.ObjectType>();
            CreateMap<UBL.ObjectType, uyumsoft.ObjectType>();

            CreateMap<uyumsoft.SignedInfoType, UBL.SignedInfoType>();
            CreateMap<UBL.SignedInfoType, uyumsoft.SignedInfoType>();
            
            CreateMap<uyumsoft.KeyInfoType, UBL.KeyInfoType>();
            CreateMap<UBL.KeyInfoType, uyumsoft.KeyInfoType>();
            
            CreateMap<uyumsoft.CanonicalizationMethodType, UBL.CanonicalizationMethodType>();
            CreateMap<UBL.CanonicalizationMethodType, uyumsoft.CanonicalizationMethodType>();
            
            CreateMap<uyumsoft.SignatureMethodType, UBL.SignatureMethodType>();
            CreateMap<UBL.SignatureMethodType, uyumsoft.SignatureMethodType>();
            
            CreateMap<uyumsoft.ReferenceType, UBL.ReferenceType>();
            CreateMap<UBL.ReferenceType, uyumsoft.ReferenceType>();
        }
    }
}
