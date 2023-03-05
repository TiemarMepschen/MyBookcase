using Domain.Books.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyBookcase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Book>> SearchBooks()
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

            return Ok(books);
        }
    }
}
