namespace Proxy.Classes
{
    public class Rate
    {
        public string RateVal { get; set; }
        public DateTime RateDate { get; set; } = DateTime.Now.AddSeconds(-10);
    }
}
