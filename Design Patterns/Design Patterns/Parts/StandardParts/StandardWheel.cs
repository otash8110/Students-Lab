using AbstractFactory.Interfaces;

namespace AbstractFactory.Parts.StandardParts
{
    public class StandardWheel : IWheel
    {
        public int WheelDiameter => 16;
    }
}
