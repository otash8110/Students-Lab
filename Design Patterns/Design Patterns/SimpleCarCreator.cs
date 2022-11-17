using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class SimpleCarCreator : ICarCreator
    {
        private readonly IAbstractPartsFactory partsFactory;

        public SimpleCarCreator(IAbstractPartsFactory partsFactory)
        {
            this.partsFactory = partsFactory;
        }

        public Car CreateCar()
        {
            var engine = partsFactory.CreateEngine();
            var suspsension = partsFactory.CreateSuspension();
            var wheel = partsFactory.CreateWheel();

            return new Car()
            {
                Wheel = wheel,
                Engine = engine,
                Suspension = suspsension
            };
        }
    }
}
