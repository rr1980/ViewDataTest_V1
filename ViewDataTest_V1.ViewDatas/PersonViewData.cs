using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.ViewDatas
{
    public class PersonViewData : IViewData
    {
        public IList<IProperty> Properties { get; set; } = new List<IProperty>();
    }
}
