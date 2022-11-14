namespace AbstractFactory.Interfaces
{
    public interface IAbstractCarFactory
    {
        IAbstractEngine CreateEngine();
        IAbstractSuspension CreateSuspension();
        IAbstractWheel CreateWheel();
    }
}
