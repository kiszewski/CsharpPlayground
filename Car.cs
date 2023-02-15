using Attributes;

namespace CarNamespace
{
    [MyAttribute("sei la")]
    class Car
    {
        public string Name;
        public int Id;
        public string Color;

        public Car(string color, string name)
        {
            this.Color = color;
            this.Name = name;
        }
    }
}


