using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlANdJsonOperationNew.Entity
{
    public class AllData<T>
    {

        public List<T> Data { get; set; }
    }
  
}
