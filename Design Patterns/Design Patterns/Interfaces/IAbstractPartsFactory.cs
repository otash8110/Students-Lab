namespace AbstractFactory.Interfaces
{
    public interface IAbstractPartsFactory
    {
        IEngine CreateEngine();
        ISuspension CreateSuspension();
        IWheel CreateWheel();
    }
}
