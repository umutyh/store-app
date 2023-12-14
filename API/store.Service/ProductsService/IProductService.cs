using store.Database.Models;
using store.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Service.ProductsService
{
    public interface IProductService
    {
        Task IncreasingTheSearchedProduct(int id);
        Task<Products> GetProductById(int id);
        Task<List<Products>> FindProductsByCategory(string category);
        Task<List<Products>> GetProductsAsync();
        Task<Products> CreateNewProduct(ProductForCreation product);
        Task<Products> UpdateProducts(ProductForUpdating product, int id);
    }
}
