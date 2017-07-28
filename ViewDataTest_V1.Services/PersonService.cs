using ViewDataTest_V1.DataBase.Interfaces;
using ViewDataTest_V1.Services.Interfaces;
using ViewDataTest_V1.ViewDatas;
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

        public IViewData Init()
        {
            var result = _repository.GetPerson();

            var vd = _viewDataBuilder.Build(new PersonViewData(), result);

            return vd;
        }
    }
}