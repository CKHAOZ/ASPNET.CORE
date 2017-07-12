using Microsoft.AspNetCore.Mvc;

namespace WebApiDos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => Content("Hello ASPNET Core");
    }
}
