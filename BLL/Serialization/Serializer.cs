using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BLL.Serialization
{
    class Serializer
    {
        private static StreamWriter sw;
        private static JsonWriter jw;
        private static JsonSerializer js = new JsonSerializer();
        private static StreamReader sr;
        private static JsonReader jr;
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            using (sw = new StreamWriter(@fileName))
            using (jw = new JsonTextWriter(sw))
            {
                js.Serialize(jw, serializableObject);
            }
        }

        public static T DeSerializeObject<T>(string fileName)
        {
            using (sr = new StreamReader(@fileName))
            using (jr = new JsonTextReader(sr))
            {
                return js.Deserialize<T>(jr);
            }
        }

    }
}
