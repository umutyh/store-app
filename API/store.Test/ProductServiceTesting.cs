using AutoFixture.Xunit2;
using AutoMapper;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace store.Test
{
    public class ProductServiceTesting
    {
        /// AAA Testing Principle
        /// A - Arrange (data that we nned to test)
        /// A - Act (run Method)
        /// A - Assert (check Result) <summary>
        /// AAA Testing Principle
        /// Naming (Method, Data, Result)

        //[Theory, AutoData]
        //public async Task increasingTheSearchedProduct_PriceIs20_NoError(
        //    [Frozen] IProductsRepository productsRepository,
        //    [Frozen] IMapper mapper,
        //    List<Table1> selectData,
        //    ProductForUpdatingDto returnData,
        //    IProductService sut)
        //{
        //    //Arrange
        //    productsRepository.GetProductsAsync().Returns(selectData);
        //    mapper.Map<ProductForUpdatingDto>(selectData).Returns(returnData);
        //    await productsRepository.UpdateProduct(returnData);

        //    ///Act
        //    await sut.increasingTheSearchedProduct(Arg.Any<int>());

        //}

        //[Theory,AutoData]
        //public async Task increasingTheSearchedProduct_PriceIs20_ThrowsError(
        //    [Frozen] IProductsRepository productsRepository,
        //    [Frozen] IMapper mapper,
        //    List<Table1> selectData,
        //    ProductForUpdatingDto returnData,
        //    IProductService sut)
        //{
        //    //Arrange
        //    productsRepository.GetProductsAsync().Returns(selectData);
        //    mapper.Map<ProductForUpdatingDto>(selectData).Returns(returnData);
        //    productsRepository.UpdateProduct(returnData).Throws<Exception>();

        //    ///Act - Assert
        //    await Assert.ThrowsAsync<Exception>(() => sut.increasingTheSearchedProduct(Arg.Any<int>()));
        //}
    }
}
