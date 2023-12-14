using Dapper;
using store.Database.Context;
using store.Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace store.Database.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DapperContext _context;


        public OrderRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersAsync()
        {
            var query = "SELECT * FROM Orders";

            using (var connection = _context.CreateConnection())
            {
                var Orders = await connection.QueryAsync<Orders>(query);
                return Orders.ToList();
            }
        }

        public async Task<IEnumerable<OrderDetails>> GetAllOrderDetailsAsync()
        {
            var query = "SELECT * ";
            query += " FROM BPraksa.dbo.Orders O";
            query += " INNER JOIN BPraksa.dbo.OrderDetails OD ON O.OrderNumber = OD.OrderNumber";

            using (var connection = _context.CreateConnection())
            {
                var OrderDetails = await connection.QueryAsync<OrderDetails>(query);
                return OrderDetails.ToList();
            }
        }

        public async Task<IEnumerable<OrdersJoinedTable>> GetOrdersCombinedTable()
        {
            var query = @"
        SELECT O.OrderNumber, O.OrderDate, O.OrderStatus, OD.Price, OD.Quantity, OD.SKU
        FROM BPraksa.dbo.Orders O
        INNER JOIN BPraksa.dbo.OrderDetails OD ON O.OrderNumber = OD.OrderNumber
    ";

            using (var connection = _context.CreateConnection())
            {
                var results = await connection.QueryAsync<OrdersJoinedTable>(query);
                return results.ToList();
            }
        }




        public async Task<Orders> CreateOrder(Orders orders)
        {
            var query = "INSERT INTO Orders (OrderDate, OrderStatus) ";
            query += " OUTPUT INSERTED.* ";
            query += " VALUES (@orderDate, @orderStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("orderDate", orders.OrderDate, DbType.DateTime);
            parameters.Add("orderStatus", orders.OrderStatus = "OK", DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var orderInformation = await connection.QuerySingleAsync<Orders>(query, parameters);
                return orderInformation;
            }
        }

        public async Task<OrderDetails> CreateOrderDetails(OrderDetails orderDetails)
        {
            string sku = GenerateRandomSKU();

            var query = "INSERT INTO OrderDetails (Price, Quantity, SKU) ";
            query += " OUTPUT INSERTED.* ";
            query += " VALUES (@price, @quantity, @sku) ";

            Orders orders = new Orders();
            var parameters = new DynamicParameters();
            parameters.Add("orderNumber", orders.OrderNumber, DbType.Int32);
            parameters.Add("price", orderDetails.Price, DbType.Decimal);
            parameters.Add("quantity", orderDetails.Quantity, DbType.Int32);
            parameters.Add("sku", sku, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var order = await connection.QuerySingleAsync<OrderDetails>(query, parameters);
                return order;
            }
        }
        private string GenerateRandomSKU()
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] sku = new char[10];
            for (int i = 0; i < 10; i++)
            {
                sku[i] = characters[random.Next(characters.Length)];
            }
            return new string(sku);
        }
        public async Task<IEnumerable<Orders>> GetOrderByNumber(int orderNumber)
        {
            var query = "SELECT * FROM Orders WHERE OrderNumber = @orderNumber";

            var parameters = new DynamicParameters();
            parameters.Add("orderNumber" ,orderNumber, DbType.Int32);

            using(var connection = _context.CreateConnection())
            {
                var order = await connection.QueryAsync<Orders>(query,parameters);
                return order;
            }
        }
        public async Task<OrderDetails> updateOrderPriceAndQuantity(OrderDetails order, int orderNumber)
        {
            var query = "UPDATE OrderDetails SET Quantity = @Quantity, Price=@Price";
            query += " OUTPUT INSERTED.* ";
            query += " WHERE OrderNumber = @orderNumber";

            var parameters = new DynamicParameters();
            parameters.Add("orderNumber", orderNumber, DbType.Int32);
            parameters.Add("Price" , order.Price, DbType.Decimal);
            parameters.Add("Quantity", order.Quantity, DbType.Int32);

            using (var connection = _context.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<OrderDetails>(query, parameters);
            }
        }

        public async Task updateOrderRow(OrderDetails order, int orderNumber)
        {
            var query = "UPDATE OrderDetails SET Quantity = @Quantity, Price=@Price";
            query += " WHERE OrderNumber = @orderNumber";

            var parameters = new DynamicParameters();
            parameters.Add("orderNumber", orderNumber, DbType.Int32);
            parameters.Add("Price", order.Price, DbType.Decimal);
            parameters.Add("Quantity", order.Quantity, DbType.Int32);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}