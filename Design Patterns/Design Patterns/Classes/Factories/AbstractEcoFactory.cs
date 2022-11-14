using AbstractFactory.Classes.EcoParts;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Factories
{
    public class AbstractEcoFactory: IAbstractCarFactory
    {
        public IAbstractEngine CreateEngine()
        {
            return new EcoEngine();
        }

        public IAbstractSuspension CreateSuspension()
        {
            return new EcoSuspension();
        }

        public IAbstractWheel CreateWheel()
        {
            return new EcoWheel();
        }
    }
}
