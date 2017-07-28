using System;
using System.Collections.Generic;
using System.Text;

namespace ViewDataTest_V1.Entities.Interfaces
{
    public interface IPerson : IEntity
    {
        string Name { get; set; }
    }
}
