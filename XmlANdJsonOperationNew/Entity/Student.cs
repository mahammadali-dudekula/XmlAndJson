using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlANdJsonOperationNew.Entity
{
   public class Student
    {
        [XmlElement(Order =1)]
        public String Name { get; set; }

        [XmlElement(Order = 2)]
        public int Age { get; set; }
    }
    public class StudentList
    {
      [XmlArray("Students")]
        public Student[] AllStudent { get; set; }
    }
}
