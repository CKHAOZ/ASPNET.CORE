using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Services;
using MyLibrary.ViewModels;

namespace MyLibrary.Controllers.Api
{
    /// <summary>
    /// Endpoint to return book information.
    /// </summary>
    [Route("api/books")]
    //[EnableCors("MyCorsPolicy")]
    public class BooksController : Controller
    {
        private readonly IBookRepository bookRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BooksController"/> class.
        /// </summary>
        public BooksController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns>A list of <see cref="BookViewModel"/></returns>
        [HttpGet("all")]
        public IActionResult List()
        {
            var books = bookRepository.GetBooks();

            return Ok(books);
        }

        /// <summary>
        /// Gets books by a given category.
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>A list of <see cref="BookViewModel"/></returns>
        [HttpGet("bycategory/{id:int}")]
        public IActionResult ByCategory(int id)
        {
            var books = bookRepository.GetBooksByCategory(id);

            if (books.Any())
            {
                return Ok(books);
            }

            return NotFound();
        }
    }
}