using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDos.ViewModels
{
    /// <summary>
    /// Represents the information to add a new category
    /// </summary>
    public class AddCategoryViewModel
    {
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
