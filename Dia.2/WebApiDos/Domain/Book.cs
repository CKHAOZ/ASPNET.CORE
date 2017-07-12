using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDos.Domain
{
    /// <summary>
    /// Book entity.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the book id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Category id.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets por sets the book name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the book description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the book year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the image url.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether the book is a best seller or not.
        /// </summary>
        public bool IsBestSeller { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the last updated date.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the book's category.
        /// </summary>
        public virtual Category Category { get; set; }
    }
}
