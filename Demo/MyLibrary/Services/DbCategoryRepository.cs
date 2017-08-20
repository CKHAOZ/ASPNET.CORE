using System;
using System.Collections.Generic;
using System.Linq;
using MyLibrary.Domain;
using MyLibrary.ViewModels;

namespace MyLibrary.Services
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
                .Where(c => c.Id == id)
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