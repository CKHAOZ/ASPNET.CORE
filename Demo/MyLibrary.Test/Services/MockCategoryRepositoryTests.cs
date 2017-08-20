using System.Collections.Generic;
using System.Linq;
using MyLibrary.Services;
using MyLibrary.ViewModels;
using Xunit;

namespace MyLibrary.Test.Services
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

        [Fact(DisplayName = "Unit.Services.MockCategoryRepository.WhenLookingForAnInvalidCategory.ShouldReturnEmpty")]
        public void WhenLookingForAnInvalidCategory_ShouldReturnEmpty()
        {
            var result = repository.GetCategoryById(100);

            Assert.Null(result);
        }

        [Fact(DisplayName = "Unit.Services.MockCategoryRepository.WhenLookingForAnValidCategory.ShouldReturnCategory")]
        public void WhenLookingForAValidCategory_ShouldReturnCategory()
        {
            var result = repository.GetCategoryById(1);

            Assert.NotNull(result);
            Assert.NotEmpty(result.Name);
            Assert.NotEmpty(result.Description);
            Assert.NotNull(result.Id);
        }

        [Fact(DisplayName = "Unit.Services.MockCategoryRepository.WhenAddACategory.ShouldAddTheCategoryToRepo")]
        public void WhenAddACategory_ShouldAddTheCategoryToRepo()
        {
            var originalCategories = repository.GetCategories();
            var totalOriginalCategories = originalCategories.Count();

            var category = new AddCategoryViewModel()
            {
                Name = "Mobile",
                Description = "Libros relacionados con el desarrollo móvil"
            };

            repository.AddCategory(category);

            var currentCategories = repository.GetCategories();
            var totalCurrentCategories = currentCategories.Count();

            Assert.True(originalCategories.Any());
            Assert.True(currentCategories.Any());
            Assert.Equal(++totalOriginalCategories, totalCurrentCategories);
        }
    }
}