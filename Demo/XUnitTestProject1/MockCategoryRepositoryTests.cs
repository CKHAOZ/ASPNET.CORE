using System.Collections.Generic;
using System.Linq;
using MyLibrary.Services;
using MyLibrary.ViewModels;
using Xunit;

namespace XUnitTestProject1
{
    public class MockCategoryRepositoryTests
    {
        private readonly ICategoryRepository repository;

        public MockCategoryRepositoryTests()
        {
            repository = new MockCategoryRepository();
        }

        [Fact(DisplayName = "Unit.Services.MockCategoryRepository.WhenHasElements.ShouldReturnCategories")]
        public void WhenHasElement_ShouldReturnCategories()
        {
            var result = repository.GetCategories();

            Assert.True(result.Any());
            Assert.IsType(typeof(List<CategoryViewModel>), result);

            foreach (var item in result)
            {
                Assert.NotEmpty(item.Name);
                Assert.NotEmpty(item.Description);
                Assert.NotNull(item.Id);
            }
        }
    }
}