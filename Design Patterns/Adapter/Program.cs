using Adapter.Services;

namespace Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            BooksAnalyzer analyzer = new BooksAnalyzer();
            Library library = new Library();

            IAdapter adapter = new Adapter(analyzer);

            adapter.GetResult(library.GetBooksXML());
        }
    }

}

