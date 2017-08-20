using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.Domain;
using WebApiDos.ViewModels;

namespace WebApiDos.Services
{
    public class DbCategoryRepository : ICategoryRepository
    {
        private readonly LibraryContext dbContext;

        public DbCategoryRepository(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CategoryViewModel> GetCategories()
        {
            return dbContext.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                })
                .ToList();
        }

        public CategoryViewModel GetCategoryById(int id)
        {
            return dbContext.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                })
                .FirstOrDefault();
        }

        public void AddCategory(AddCategoryViewModel categoryViewModel)
        {
            dbContext.Categories.Add(
                new Category(categoryViewModel.Name, categoryViewModel.Description)
                {
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                });

            dbContext.SaveChanges();
        }
    }
}
