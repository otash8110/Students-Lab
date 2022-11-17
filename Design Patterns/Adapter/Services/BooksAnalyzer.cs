using Adapter.Models;
using System.Text.Json;

namespace Adapter.Services
{
    public class BooksAnalyzer
    {
        public JsonDocument GetOldestBook(JsonDocument books)
        {
            Books booksObject = JsonSerializer.Deserialize<Books>(books);

            var oldestBook = booksObject.Book.OrderBy(book => book.Date).FirstOrDefault();
            var convertedOldestBook = JsonSerializer.Serialize(oldestBook);

            return JsonDocument.Parse(convertedOldestBook);
        }
    }
}
