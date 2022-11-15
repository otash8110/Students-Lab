namespace Proxy
{
    public class Rate
    {
        public string Value { get; set; }
        public DateTime Date { get; set; } = DateTime.Today.AddDays(-1);
    }
}
