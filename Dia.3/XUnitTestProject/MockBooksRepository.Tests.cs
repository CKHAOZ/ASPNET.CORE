using WebApiDos.Services;
using WebApiDos.ViewModels;
using Xunit;


namespace XUnitTestProject
{
    public class MockBooksRepository
    {
		private readonly IBookRepository repository;

        public MockBooksRepository()
        {
            repository = new MockBookRepository();
        }
		
        [Fact(DisplayName = "Unit.Services.MockBooksRepository.WhenSearchBookById.behaiver")]
        public void WhenSearchBookById_behaiver()
        {
            BookViewModel book = repository.GetBookById(1);

			// no tiene sentido si no uso VAR
            Assert.IsType(typeof(BookViewModel), book);

            if (book != null)
            {
                Assert.NotNull(book.Id);
                Assert.NotEmpty(book.Name);
                Assert.NotEmpty(book.Description);
                Assert.NotEmpty(book.Category);
            }
        }
    }
}
