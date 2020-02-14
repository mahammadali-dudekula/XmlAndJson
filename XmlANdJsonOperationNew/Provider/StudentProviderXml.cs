using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class StudentProviderXml
    {
       public void Serialization(StudentList list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StudentList));
            TextWriter writer = new StreamWriter("MyStudentSirialization.xml");
            serializer.Serialize(writer, list);
            writer.Close();
        }
        public StudentList Deserialization()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StudentList));
            StudentList Value;
            using (Stream reader = new FileStream("MyStudentSirialization.xml", FileMode.Open))
            {
                Value = (StudentList)serializer.Deserialize(reader);
            }
            return Value;
        }
        

    }
}
