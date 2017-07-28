using System;
using System.Collections.Generic;
using System.Text;

namespace ViewDataTest_V1.ViewDatas.Interfaces
{
    public interface IViewDataBuilder
    {
        IViewData Build<E>(IViewData viewData, E result);
    }
}
