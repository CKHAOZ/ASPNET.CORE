using Microsoft.AspNetCore.Mvc;
using MyLibrary.Services;

namespace MyLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            this.bookRepository = bookRepository;
            this.categoryRepository = categoryRepository;
        }
        
        public IActionResult List()
        {
            var books = bookRepository.GetBooks();
            ViewBag.CategoryName = "Todos nuestros libros";
            return View(books);
        }

        public IActionResult ByCategory(int id)
        {
            var category = categoryRepository.GetCategoryById(id);
            var books = bookRepository.GetBooksByCategory(id);

            ViewBag.CategoryName = category.Name;
            ViewBag.CategoryDescription = category.Description;
            return View("List",books);
        }
    }
}