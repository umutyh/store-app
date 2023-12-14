using System.Collections.Generic;
using System.Threading.Tasks;
using XStoreApp.ServiceClient.Models;


namespace XStore.Service.ProductService
{
    public interface IProductService
    {
        Task IncreasingTheSearchedProduct(int id);
        Task<Products> GetProductById(int id);
        Task<List<Products>> FindProductsByCategory(string category);
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products> CreateNewProduct(ProductForCreation product);
        Task<Products> UpdateProducts(ProductForUpdating product, int id); 
    }
}
