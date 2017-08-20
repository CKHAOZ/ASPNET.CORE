using System.Collections.Generic;
using System.Linq;
using MyLibrary.Domain;
using MyLibrary.ViewModels;

namespace MyLibrary.Services
{
    public class DbBookRepository : IBookRepository
    {
        private readonly LibraryContext dbContext;

        public DbBookRepository(LibraryContext dbContext)
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