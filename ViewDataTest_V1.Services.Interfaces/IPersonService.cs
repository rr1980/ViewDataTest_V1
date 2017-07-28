using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.Services.Interfaces
{
    public interface IPersonService
    {
        IViewData Init();
    }
}
