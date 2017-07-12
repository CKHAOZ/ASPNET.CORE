using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.ViewModels;

namespace WebApiDos.Services
{
    /// <summary>
    /// Repository to manage books.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Gets all books.
        /// </summary>
        /// <returns>A list of <see cref="BookViewModel"/></returns>
        IEnumerable<BookViewModel> GetBooks();

        /// <summary>
        /// Gets best seller books. 
        /// </summary>
        /// <returns>A list of <see cref="BookViewModel"/></returns>
        IEnumerable<BookViewModel> GetBestSellerBooks();

        /// <summary>
        /// Get books by a given category.
        /// </summary>
        /// <param name="categoryId">Category id</param>
        /// <returns>A list of <see cref="BookViewModel"/></returns>
        IEnumerable<BookViewModel> GetBooksByCategory(int categoryId);

        /// <summary>
        /// Gets a book.
        /// </summary>
        /// <param name="id">Book id</param>
        /// <returns>A <see cref="BookViewModel"/></returns>
        BookViewModel GetBookById(int id);
    }
}
