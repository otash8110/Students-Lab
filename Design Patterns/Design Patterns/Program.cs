using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Factory can be changed without any negative consequences to code
            // This results in different behaviour with almost the same code
            IAbstractPartsFactory factory = GetFactory(CarConfiguration.Extra);
            ICarCreator carCreator = new SimpleCarCreator(factory);

            Car car = carCreator.CreateCar();
            Console.WriteLine(car.Engine.GetType().Name);
            Console.WriteLine(car.Suspension.GetType().Name);
            Console.WriteLine(car.Wheel.GetType().Name);
        }

        private static IAbstractPartsFactory GetFactory(CarConfiguration carConfig)
        {
            if (carConfig == CarConfiguration.Economy) return new AbstractEcoFactory();
            else if (carConfig == CarConfiguration.Extra) return new AbstractExtraFactory();
            else return new AbstractStandardFactory();
        }
    }
}
