using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlANdJsonOperationNew.Entity
{
    public class Employee
    {
        [XmlElement(Order = 1)]
        public String Name { get; set; }

        [XmlElement(Order = 2)]
        public long Salery { get; set; }
    }
    public class EmployeeList
    {
        [XmlArray("Employees")]
        public Employee[] AllEmployees { get; set; }
    }
}
