using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.Domain;
using WebApiDos.ViewModels;

namespace WebApiDos.Services
{
    /// <summary>
    /// Repository to manage categories.
    /// </summary>
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockCategoryRepository"/>
        /// </summary>
        public MockCategoryRepository()
        {
            categories = new List<Category>()
        {
            new Category("Microsoft & .NET", "Libros relacionados con Microsoft y el .Net Framework")
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new Category("Game development", "Libros relacionados con la creación de juegos 2D y 3D")
            {
                Id = 2,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            }
        };
        }

        /// <inheritdoc />
        public IEnumerable<CategoryViewModel> GetCategories()
        {
            return categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                })
                .ToList();
        }

        /// <inheritdoc />
        public CategoryViewModel GetCategoryById(int id)
        {
            return categories
                .Where(c => c.Id == id)
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                })
                .FirstOrDefault();
        }

        /// <inheritdoc />
        public void AddCategory(AddCategoryViewModel categoryViewModel)
        {
            var maxId = categories.Count;
            maxId++;

            categories.Add(new Category(categoryViewModel.Name, categoryViewModel.Description)
            {
                Id = maxId,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            });
        }
    }
}
