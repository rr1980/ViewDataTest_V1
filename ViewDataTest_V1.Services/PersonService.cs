using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.DataBase.Interfaces;
using ViewDataTest_V1.Services.Interfaces;

namespace ViewDataTest_V1.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository _repository;

        public PersonService(IRepository repository)
        {
            _repository = repository;
        }
    }
}
