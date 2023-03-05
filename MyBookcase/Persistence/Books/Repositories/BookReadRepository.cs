using Domain.Books.Entities;
using Domain.Books.Interfaces;
using Domain.Books.Queries;

namespace Persistence.Books.Repositories
{
    public sealed class BookReadRepository : IBookReadRepository
    {
        public IEnumerable<Book> SearchBooks(SearchBooksQuery query)
        {
            var books = new List<Book>()
            {
                new Book()
                {
                    Title = "book1"
                },
                new Book()
                {
                    Title = "book2"
                }
            };

            return books;
        }
    }
}