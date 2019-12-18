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
        }
    }
}
