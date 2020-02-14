using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class StudentProviderJson
    {
        public void SerializeData(StudentList list)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter st = new StreamWriter("Mystudent.json"))
            using (JsonWriter Jw=new JsonTextWriter(st))
            {
                serializer.Serialize(Jw,list);
            }
        }
        public StudentList DeserializeStudent()
        {
            StudentList list = JsonConvert.DeserializeObject<StudentList>(File.ReadAllText("Mystudent.json"));
            return list;
        }

    }
}
