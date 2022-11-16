using Adapter.Services;
using System.Text.Json;
using System.Xml;

namespace Adapter
{
    public class Adapter : IAdapter
    {
        private readonly BooksAnalyzer analyzer;

        public Adapter(BooksAnalyzer analyzer)
        {
            this.analyzer = analyzer;
        }

        public JsonDocument GetResult(XmlDocument books)
        {
            var jsonBooks = XmlToJson(books);
            return this.analyzer.GetOldestBook(jsonBooks);
        }

        private JsonDocument XmlToJson(XmlDocument document)
        {
            var convertedString = Newtonsoft.Json.JsonConvert.SerializeXmlNode(document, Newtonsoft.Json.Formatting.None, true);
            return JsonDocument.Parse(convertedString);
        }
    }
}
