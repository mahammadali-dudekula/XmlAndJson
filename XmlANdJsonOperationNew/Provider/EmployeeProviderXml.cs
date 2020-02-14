using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlANdJsonOperationNew.Entity;

namespace XmlANdJsonOperationNew.Provider
{
    class EmployeeProviderXml
    {
       public void EmployeeSerialization(EmployeeList list1)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmployeeList));
            TextWriter textWriter = new StreamWriter("MyEmployeeDeatils.xml");
            xmlSerializer.Serialize(textWriter, list1);
            textWriter.Close();
        }
        public EmployeeList Deserialization()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(EmployeeList));
            EmployeeList Value1;
            using (Stream reader = new FileStream("MyEmployeeDeatils.xml", FileMode.Open))
            {
                Value1 = (EmployeeList)serializer.Deserialize(reader);
            }
            return Value1;
        }
    }
}
