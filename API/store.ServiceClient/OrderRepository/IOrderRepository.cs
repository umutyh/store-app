using store.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Database.OrderRepository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Orders>> GetAllOrdersAsync();
        Task<IEnumerable<OrderDetails>> GetAllOrderDetailsAsync();

        Task<IEnumerable<OrdersJoinedTable>> GetOrdersCombinedTable();
        Task<Orders> CreateOrder(Orders orders);
        Task<OrderDetails> CreateOrderDetails(OrderDetails orderDetails);
        Task<IEnumerable<Orders>> GetOrderByNumber(int orderNumber);
        Task<OrderDetails> updateOrderPriceAndQuantity(OrderDetails order, int orderNumber);
        Task updateOrderRow(OrderDetails order, int orderNumber);
    }
}
