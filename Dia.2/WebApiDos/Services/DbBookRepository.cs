using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.Domain;
using WebApiDos.ViewModels;

namespace WebApiDos.Services
{
    public class DbBookReppository : IBookRepository
    {
        private readonly LibraryContext dbContext;

        public DbBookReppository(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<BookViewModel> GetBooks()
        {
            return dbContext.Books
                .Select(c => new BookViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    Name = c.Name,
                    Year = c.Year,
                    IsBestSeller = c.IsBestSeller,
                    Author = c.Author,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .ToList();
        }

        public IEnumerable<BookViewModel> GetBestSellerBooks()
        {
            return dbContext.Books
                .Where(c => c.IsBestSeller)
                .Select(c => new BookViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    Name = c.Name,
                    Year = c.Year,
                    IsBestSeller = c.IsBestSeller,
                    Author = c.Author,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .ToList();
        }

        public IEnumerable<BookViewModel> GetBooksByCategory(int categoryId)
        {
            return dbContext.Books
                .Where(c => c.CategoryId == categoryId)
                .Select(c => new BookViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    Name = c.Name,
                    Year = c.Year,
                    IsBestSeller = c.IsBestSeller,
                    Author = c.Author,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .ToList();
        }

        public BookViewModel GetBookById(int id)
        {
            return dbContext.Books
                .Where(c => c.Id == id)
                .Select(c => new BookViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    Name = c.Name,
                    Year = c.Year,
                    IsBestSeller = c.IsBestSeller,
                    Author = c.Author,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .FirstOrDefault();
        }
    }
}
