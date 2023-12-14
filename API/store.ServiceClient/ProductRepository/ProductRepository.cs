using Dapper;
using store.Database.Models;
using store.Database.Context;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace store.Database.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;
        public ProductRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Table1>> GetProductsAsync()
        {
            var query = "SELECT * FROM Table_1";
            using (var connection = _context.CreateConnection())
            {
                var Table1 = await connection.QueryAsync<Table1>(query);
                return Table1.ToList();
            }
        }

        public async Task<Table1> CreateProduct(Table1 product)
        {
            var query = "INSERT INTO Table_1 (ProductID, ProductName, category,Price) ";
            query += " OUTPUT INSERTED.* ";
            query += " VALUES (@productId,@productName, @category, @price) ";
            var parameters = new DynamicParameters();
            parameters.Add("productId", product.ProductId, DbType.Int32);
            parameters.Add("productName", product.ProductName, DbType.String);
            parameters.Add("category", product.Category, DbType.String);
            parameters.Add("price", product.Price, DbType.Decimal);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QuerySingleAsync<Table1>(query, parameters);
                return value;
            }
        }

        public async Task<Table1> GetCombinedTableResult(int id)
        {
            var procedureName = "ShowProductById";
            var parameters = new DynamicParameters();
            parameters.Add("productId", id, DbType.Int32, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<Table1>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
            }

        }

        public async Task<Table1> UpdateProduct(Table1 product, int id)
        {
            var query = "UPDATE Table_1 SET productName = @productName, price = @price";
            query += " OUTPUT INSERTED.* ";
            query += " WHERE productId = @productId";

            var parameters = new DynamicParameters();
            parameters.Add("productId", id, DbType.Int32);
            parameters.Add("productName", product.ProductName, DbType.String);
            parameters.Add("price", product.Price, DbType.Decimal);

            using (var connection = _context.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<Table1>(query, parameters);
            }
        }

        public async Task<IEnumerable<Table1>> GetByCategory(string category)
        {
            var query = "SELECT * FROM Table_1 WHERE category = @category";

            var parameters = new DynamicParameters();
            parameters.Add("category", category, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var Table1 = await connection.QueryAsync<Table1>(query, parameters);
                return Table1.ToList();
            }
        }
    }
}