using AbstractFactory.Interfaces;
using AbstractFactory.Parts.StandardParts;

namespace AbstractFactory.Factories
{
    public class AbstractStandardFactory : IAbstractPartsFactory
    {
        public IEngine CreateEngine()
        {
            return new StandardEngine();
        }

        public ISuspension CreateSuspension()
        {
            return new StandardSuspension();
        }

        public IWheel CreateWheel()
        {
            return new StandardWheel();
        }
    }
}
