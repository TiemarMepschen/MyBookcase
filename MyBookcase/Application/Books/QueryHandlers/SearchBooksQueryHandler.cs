using Domain.Books.Entities;
using Domain.Books.Interfaces;
using Domain.Books.Queries;
using MediatR;

namespace Application.Books.QueryHandlers
{
    public sealed class SearchBooksQueryHandler : IRequestHandler<SearchBooksQuery, IEnumerable<Book>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public SearchBooksQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public Task<IEnumerable<Book>> Handle(SearchBooksQuery request, CancellationToken cancellationToken)
        {
            var books = _bookReadRepository.SearchBooks(request);

            return Task.FromResult(books);
        }
    }
}