using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.Domain;
using WebApiDos.ViewModels;

namespace WebApiDos.Services
{
    /// <summary>
    /// Repository to manage books.
    /// </summary>
    public class MockBookRepository : IBookRepository
    {
        private readonly List<Category> categories;
        private readonly List<Book> books;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockBookRepository"/> class.
        /// </summary>
        public MockBookRepository()
        {
            categories = new List<Category>
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

            books = new List<Book>
        {
            new Book
            {
                Id = 1,
                CategoryId = 1,
                Name = "Practical Azure Application Development",
                Description = "Get started and learn a step-by-step approach to application development using Microsoft Azure. Select the right services to solve the problem at hand in a cost-effective manner and explore the potential different services and how they can help in building enterprise applications. Azure has an ample amount of resources and tutorials, but most of them focus on specific services and explain those services on their own and in a given context. Practical Azure Application Development focuses on building complete solutions on Azure using different services. This book gives you the holistic approach to Azure as a solutions development platform.",
                Author = "Vijayakumar, Thurupathan",
                Year = 2017,
                IsBestSeller = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Category = categories.FirstOrDefault(c => c.Id == 1)
            },
            new Book
            {
                Id = 2,
                CategoryId = 1,
                Name = "Develop Microsoft HoloLens Apps Now",
                Description = "This is the first book to describe the Microsoft HoloLens wearable augmented reality device and provide step-by-step instructions on how developers can use the HoloLens SDK to create Windows 10 applications that merge holographic virtual reality with the wearer’s actual environment. Best-selling author Allen G. Taylor explains how to develop and deliver HoloLens applications via Microsoft’s ecosystem for third party apps.Readers will also learn how HoloLens differs from other virtual and augmented reality devices and how to create compelling applications to fully utilize its capabilities.",
                Author = "Taylor, Allen G.",
                Year = 2017,
                IsBestSeller = false,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Category = categories.FirstOrDefault(c => c.Id == 1)
            },
            new Book
            {
                Id = 3,
                CategoryId = 2,
                Name = "C# 6.0 and the .NET 4.6 Framework",
                Description = "This new 7th edition of Pro C# 6.0 and the .NET 4.6 Platform has been completely revised and rewritten to reflect the latest changes to the C# language specification and new advances in the .NET Framework. You'll find new chapters covering all the important new features that make .NET 4.6 the most comprehensive release yet.",
                Author = "TROELSEN, ANDREW, Japikse, Philip",
                Year = 2015,
                IsBestSeller = true,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Category = categories.FirstOrDefault(c => c.Id == 2)
            }
        };
        }

        /// <inheritdoc />
        public IEnumerable<BookViewModel> GetBooks()
        {
            return books
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

        /// <inheritdoc />
        public IEnumerable<BookViewModel> GetBestSellerBooks()
        {
            return books
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

        /// <inheritdoc />
        public IEnumerable<BookViewModel> GetBooksByCategory(int categoryId)
        {
            return books
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

        /// <inheritdoc />
        public BookViewModel GetBookById(int id)
        {
            return books
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
