using store.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Database.ProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Table1>> GetProductsAsync();
        Task<Table1> CreateProduct(Table1 product);
        Task<Table1> GetCombinedTableResult(int id);

        Task<Table1> UpdateProduct(Table1 product, int id);
        Task<IEnumerable<Table1>> GetByCategory(string category);
    }
}
