using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.StandardParts
{
    public class StandardWheel : IAbstractWheel
    {
        public int WheelDiameter => 16;
    }
}
