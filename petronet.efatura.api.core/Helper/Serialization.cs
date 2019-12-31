using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace petronet.efatura.api.core.Helper {
    public class Serialization {
        static public byte[] SerializeToBytes<T>(T obj) {
            using (MemoryStream ms = new MemoryStream()) {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
    }
}
