using AbstractFactory.Classes.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Factory can be changed without any negative consequences to code
            // This results in different behaviour with almost the same code
            IAbstractCarFactory factory = new AbstractExtraFactory();

            IAbstractEngine engine = factory.CreateEngine();
            IAbstractSuspension suspension = factory.CreateSuspension();
            IAbstractWheel wheel = factory.CreateWheel();
        }
    }

}

