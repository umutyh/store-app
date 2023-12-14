using store.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Service.OrderService
{
    public interface IOrderService
    {
        Task<List<OrderInfoServiceDB>> GetAllOrdersInformation();
        Task<List<OrderDetailServiceDB>> GetAllOrdersDetails();
        Task<OrderInfoServiceDB> CreateOrderInfo(OrderInfoCreation orderCreation);
        Task<OrderDetailServiceDB> CreateOrderDet(OrderDetailCreation orderDetail);
        Task<List<OrderDetailsCombined>> GetOrdersCombined();
        Task<List<OrderInfoServiceDB>> OrderByOrderNumber(int orderNumber);
        Task<OrderDetailServiceDB>UpdateOrderPrice(OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber);
        Task UpdateOrderRow(OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber);
    }
}
