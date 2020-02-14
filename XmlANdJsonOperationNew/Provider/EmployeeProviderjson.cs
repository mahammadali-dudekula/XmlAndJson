using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class EmployeeProviderjson
    {
        public void SerializeData(EmployeeList list)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter st = new StreamWriter("MyEmployee.json"))
            using (JsonWriter Jw = new JsonTextWriter(st))
            {
                serializer.Serialize(Jw, list);
            }
        }
        public EmployeeList DeserializeEmployee()
        {
            EmployeeList list = JsonConvert.DeserializeObject<EmployeeList>(File.ReadAllText("MyEmployee.json"));
            return list;
        }
    }
}
