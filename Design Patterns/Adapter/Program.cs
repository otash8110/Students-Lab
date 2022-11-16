using Adapter.Services;
using System.Text.Json;

namespace Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            BooksAnalyzer analyzer = new BooksAnalyzer();
            Library library = new Library();

            IAdapter adapter = new Adapter(analyzer);

            var result = adapter.GetResult(library.GetBooksXML());

            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}

