using System;
using System.Collections.Generic;
using System.Text;

namespace ViewDataTest_V1.ViewDatas.Interfaces
{
    public interface IPersonViewData
    {
        IProperty<string> Name { get; set; }
    }
}
