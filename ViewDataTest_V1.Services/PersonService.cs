using System;
using System.Collections.Generic;
using System.Text;
using ViewDataTest_V1.DataBase.Interfaces;
using ViewDataTest_V1.Services.Interfaces;
using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository _repository;
        private readonly IViewDataBuilder _viewDataBuilder;

        public PersonService(IRepository repository, IViewDataBuilder viewDataBuilder)
        {
            _repository = repository;
            _viewDataBuilder = viewDataBuilder;
        }

        public IPersonViewData Init()
        {
            var result = _repository.GetPerson();

            return _viewDataBuilder.Build<IPersonViewData>(result);
        }
    }
}
