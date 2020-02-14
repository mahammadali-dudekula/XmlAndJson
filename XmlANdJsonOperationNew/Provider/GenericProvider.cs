using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class GenericProvider<T>
    {
        public void Serialization(AllData<T> allData,string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AllData<T>));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, allData);
            writer.Close();
        }
        public AllData<T> Deserialization(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AllData<T>));
            AllData<T> Value;
            using (Stream reader = new FileStream(path, FileMode.Open))
            {
                Value = (AllData<T>)serializer.Deserialize(reader);
            }
            return Value;
        }
    }
}
