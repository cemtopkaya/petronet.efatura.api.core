using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace petronet.efatura.api.core.ViewModel
{
    public class ServiceInfo {
        /// <summary>
        /// DijitalPlanet için şirket kodu girilir
        /// </summary>
        [FromHeader]
        public string CorporateCode { get; set; }

        [FromHeader]
        [Required]
        public string UserName { get; set; }

        [FromHeader]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Web Servisinin adresidir. Bu bilgi dolu gelirse geçerli olur.
        /// Aksi halde ayar dosyasındaki değer kullanılır.
        /// </summary>
        [FromHeader]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gelir İdaresi Başkanlığı portalında bir firmanın merkezini
        /// ve şubelerini ayırt etmek için kullanılan posta kutusunu belirtir. 
        /// </summary>
        [FromHeader]
        public string ReceiverPostboxName { get; set; }

        /// <summary>
        /// Hangi entegratör için veri gönderileceğini belirtir. Mecburidir!
        /// </summary>
        [FromHeader]
        [Required]
        public Integrator Integrator { get; set; }
    }
}