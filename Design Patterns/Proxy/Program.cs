namespace Proxy
{
    class Program
    {
        public static void Main(string[] args)
        {
            YesterdayRate yesterdayRate = new YesterdayRate();
            ProxyYesterdayRate proxyYesterdayRate = new ProxyYesterdayRate(yesterdayRate);

            proxyYesterdayRate.GetRate();
            Thread.Sleep(4000);
            proxyYesterdayRate.GetRate();
            Thread.Sleep(7000);
            proxyYesterdayRate.GetRate();

        }
    }

}

