using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDos.ViewModels
{
    /// <summary>
    /// Represents a category.
    /// </summary>
    public class CategoryViewModel
    {
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category description.
        /// </summary>
        public string Description { get; set; }
    }
}
