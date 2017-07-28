using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.DataBase.Interfaces;
using ViewDataTest_V1.Entities;
using ViewDataTest_V1.Entities.Interfaces;

namespace ViewDataTest_V1.DataBase
{
    public class Repository : IRepository
    {
        public IPerson GetPerson()
        {
            return new Person("Rene", 1);
        }
    }
}
