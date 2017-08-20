using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Services;

namespace MyLibrary.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.GetCategories().OrderBy(c => c.Name);
            return View(categories);
        }
    }
}