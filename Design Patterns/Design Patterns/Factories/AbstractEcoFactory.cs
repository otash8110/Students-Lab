using AbstractFactory.Interfaces;
using AbstractFactory.Parts.EcoParts;

namespace AbstractFactory.Factories
{
    public class AbstractEcoFactory : IAbstractPartsFactory
    {
        public IEngine CreateEngine()
        {
            return new EcoEngine();
        }

        public ISuspension CreateSuspension()
        {
            return new EcoSuspension();
        }

        public IWheel CreateWheel()
        {
            return new EcoWheel();
        }
    }
}
