using System.Collections.Generic;
using MyLibrary.ViewModels;

namespace MyLibrary.Services
{
    /// <summary>
    /// Repository to manage categories.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Get all categories.
        /// </summary>
        /// <returns>A list of <see cref="CategoryViewModel"/></returns>
        IEnumerable<CategoryViewModel> GetCategories();

        /// <summary>
        /// Get a category.
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>A <see cref="CategoryViewModel"/></returns>
        CategoryViewModel GetCategoryById(int id);

        /// <summary>
        /// Creates a new category.
        /// </summary>
        /// <param name="categoryViewModel">A <see cref="AddCategoryViewModel"/></param>
        void AddCategory(AddCategoryViewModel categoryViewModel);
    }
}