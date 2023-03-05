using Domain.Books.Entities;
using MediatR;

namespace Domain.Books.Queries
{
    public sealed class SearchBooksQuery : IRequest<IEnumerable<Book>>
    {

    }
}