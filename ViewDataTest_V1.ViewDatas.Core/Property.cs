using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.ViewDatas.Core
{
    public class Property : IProperty
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Value_String { get; set; }

        public Property()
        {

        }

        //public Property(string type, string name)
        //{
        //    Type = type;
        //    Name = name;
        //}
    }
}