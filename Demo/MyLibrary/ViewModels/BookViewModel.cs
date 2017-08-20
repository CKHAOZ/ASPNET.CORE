namespace MyLibrary.ViewModels
{
    /// <summary>
    /// Represents a book.
    /// </summary>
    public class BookViewModel
    {
        /// <summary>
        /// Gets or sets the book id.
        /// </summary>
        public int Id { get; set; }

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
        /// Gets or sets a value indicating wheter the book is a best seller or not.
        /// </summary>
        public bool IsBestSeller { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string Category { get; set; }
    }
}