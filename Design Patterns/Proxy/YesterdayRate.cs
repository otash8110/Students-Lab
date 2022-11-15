namespace Proxy
{
    public class YesterdayRate : IYesterdayRate
    {
        public Rate GetRate()
        {
            return new Rate();
        }
    }
}
