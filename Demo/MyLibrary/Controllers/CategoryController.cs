using Microsoft.AspNetCore.Mvc;
using MyLibrary.Services;

namespace MyLibrary.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository repository;

        public CategoryController(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult List()
        {
            var categories = repository.GetCategories();
            return View(categories);
        }
    }
}