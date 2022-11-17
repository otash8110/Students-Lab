namespace Proxy
{
    public class ProxyYesterdayRate : IYesterdayRate
    {
        private readonly YesterdayRate _yesterdayRate;
        private Rate _rate;

        public ProxyYesterdayRate(YesterdayRate yesterdayRate)
        {
            _yesterdayRate = yesterdayRate;
        }

        public Rate GetRate()
        {
            if (_rate == null || this.CheckCache())
            {
                Console.WriteLine("Making new request...");
                _rate = _yesterdayRate.GetRate();
            } else
            {
                Console.WriteLine("Getting from cache");
            }

            return _rate;
        }

        private bool CheckCache()
        {
            return _rate != null && _rate.Date != DateTime.Today.AddDays(-1);
        }
    }
}
