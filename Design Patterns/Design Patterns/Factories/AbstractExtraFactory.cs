using AbstractFactory.Interfaces;
using AbstractFactory.Parts.ExtraParts;

namespace AbstractFactory.Factories
{
    public class AbstractExtraFactory : IAbstractPartsFactory
    {
        public IEngine CreateEngine()
        {
            return new ExtraEngine();
        }

        public ISuspension CreateSuspension()
        {
            return new ExtraSuspension();
        }

        public IWheel CreateWheel()
        {
            return new ExtraWheel();
        }
    }
}
