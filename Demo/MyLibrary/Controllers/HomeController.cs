using Microsoft.AspNetCore.Mvc;
using MyLibrary.Services;

namespace MyLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository mockBookRepository;

        public HomeController(IBookRepository mockBookRepository)
        {
            this.mockBookRepository = mockBookRepository;
        }

        public IActionResult Index()
        {
            var topBooks = mockBookRepository.GetBestSellerBooks();
            return View(topBooks);
        }

        public IActionResult Error() => Content("Algo ha ido mal :(... luego tendremos una linda página de error");
    }
}