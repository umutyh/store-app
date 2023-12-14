using store.Database.Products;
using Xunit;

namespace store.Test
{
    public class ProductRepositoryTesting
    {
        private readonly IProductRepository _productsRepository;
        public ProductRepositoryTesting(IProductRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        /// AAA Testing Principle
        /// A - Arrange (data that we nned to test)
        /// A - Act (run Method)
        /// A - Assert (check Result) <summary>
        /// AAA Testing Principle
        /// Naming (Method, Data, Result)
        [Fact]
        public async Task GetProductsAsync_ShowsProducts_ThrowsException()
        {
            var act = await _productsRepository.GetProductsAsync();

            await Assert.ThrowsAsync<Exception>(async () => await _productsRepository.GetProductsAsync());
        }

    }
}
