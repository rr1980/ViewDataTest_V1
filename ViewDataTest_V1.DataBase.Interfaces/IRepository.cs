using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.Entities.Interfaces;

namespace ViewDataTest_V1.DataBase.Interfaces
{
    public interface IRepository
    {
        IPerson GetPerson();
    }
}
