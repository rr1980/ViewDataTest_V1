using ViewDataTest_V1.Common;
using ViewDataTest_V1.Entities.Common;

namespace ViewDataTest_V1.Entities.Interfaces
{
    public interface IPerson : IEntity
    {
        [Propertie("Name", PropertyEnum.String)]
        string Name { get; set; }
    }
}