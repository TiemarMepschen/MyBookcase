using Domain.Books.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Books.Repositories;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<IBookReadRepository, BookReadRepository>();
        }
    }
}