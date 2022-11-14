using AbstractFactory.Classes.StandardParts;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Factories
{
    public class AbstractStandardFactory: IAbstractCarFactory
    {
        public IAbstractEngine CreateEngine()
        {
            return new StandardEngine();
        }

        public IAbstractSuspension CreateSuspension()
        {
            return new StandardSuspension();
        }

        public IAbstractWheel CreateWheel()
        {
            return new StandardWheel();
        }
    }
}
