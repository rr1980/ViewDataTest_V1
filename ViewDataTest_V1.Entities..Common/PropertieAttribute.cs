using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.Common;

namespace ViewDataTest_V1.Entities.Common
{
    public class PropertieAttribute : Attribute
    {
        public string Name { get; set; }
        public PropertyEnum Type { get; set; }

        public PropertieAttribute(string name, PropertyEnum type)
        {
            Name = name;
            Type = type;
        }    
    }
}
