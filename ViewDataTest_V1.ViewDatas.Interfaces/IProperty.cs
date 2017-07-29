using System;
using System.Collections.Generic;
using System.Text;

namespace ViewDataTest_V1.ViewDatas.Interfaces
{
    public interface IProperty
    {
        string Name { get; set; }
        string Type { get; set; }

        string Value_String { get; set; }
    }
}
