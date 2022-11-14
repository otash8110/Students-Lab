using AbstractFactory.Classes.ExtraParts;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Factories
{
    public class AbstractExtraFactory: IAbstractCarFactory
    {
        public IAbstractEngine CreateEngine()
        {
            return new ExtraEngine();
        }

        public IAbstractSuspension CreateSuspension()
        {
            return new ExtraSuspension();
        }

        public IAbstractWheel CreateWheel()
        {
            return new ExtraWheel();
        }
    }
}
