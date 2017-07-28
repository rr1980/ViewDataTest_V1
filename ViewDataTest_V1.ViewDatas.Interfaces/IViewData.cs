using System;
using System.Collections.Generic;
using System.Text;

namespace ViewDataTest_V1.ViewDatas.Interfaces
{
    public interface IViewData
    {
        IList<IProperty> Properties { get; set; }
    }
}
