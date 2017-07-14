using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiDos.Domain;
using WebApiDos.Infrastructure;
using WebApiDos.Services;
using WebApiDos.ViewModels;
using WebApiDos.Services;

namespace WebApiDos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository mockBookRepository;

        public HomeController()
        {
            mockBookRepository = new MockBookRepository();
        }

        public IActionResult Index()
        {
            var topBooks = mockBookRepository.GetBestSellerBooks();
            return View(topBooks);
        }

        //public IActionResult Index() => Content("Hello ASPNET Core");
    }
}
