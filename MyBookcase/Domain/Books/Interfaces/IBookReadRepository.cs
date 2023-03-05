using Domain.Books.Entities;
using Domain.Books.Queries;

namespace Domain.Books.Interfaces
{
    public interface IBookReadRepository
    {
        public IEnumerable<Book> SearchBooks(SearchBooksQuery query);
    }
}