using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Car
    {
        public IWheel Wheel { get; set; }
        public ISuspension Suspension { get; set; }
        public IEngine Engine { get; set; }
    }
}
