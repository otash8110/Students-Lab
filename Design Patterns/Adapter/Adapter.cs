using Adapter.Classes;
using Adapter.Services;

namespace Adapter
{
    public class Adapter : IAdapter
    {
        private readonly BooksAnalyzer _analyzer;

        public Adapter(BooksAnalyzer analyzer)
        {
            this._analyzer = analyzer;
        }

        public JSON GetResult(XML book)
        {
            return this._analyzer.GetOldestBook(book);
        }
    }
}
