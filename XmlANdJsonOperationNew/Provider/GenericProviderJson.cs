using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class GenericProviderJson<T>
    {
        public void SerializeDataGeneric(AllData<T> list,string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter st = new StreamWriter(path))
            using (JsonWriter Jw = new JsonTextWriter(st))
            {
                serializer.Serialize(Jw, list);
            }
        }
        public AllData<T> DeserializeStudentGEneric(string path)
        {
            AllData<T> list = JsonConvert.DeserializeObject<AllData<T>>(File.ReadAllText(path));
            return list;
        }
    }
}
