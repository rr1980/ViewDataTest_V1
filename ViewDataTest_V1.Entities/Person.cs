using ViewDataTest_V1.Entities.Interfaces;

namespace ViewDataTest_V1.Entities
{
    public class Person : IPerson
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Person(string name, long id)
        {
            Id = id;
            Name = name;
        }
    }
}