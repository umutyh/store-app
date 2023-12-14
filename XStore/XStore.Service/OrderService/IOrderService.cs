using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XStoreApp.ServiceClient.Models;

namespace XStore.Service.OrderService
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderInfoServiceDB>> GetAllOrdersInformation();
        Task<IEnumerable<OrderDetailServiceDB>> GetAllOrdersDetails();
        Task<List<OrderInfoServiceDB>>GetOrderByOrderNumber(int orderNumber);
        Task UpdatePriceAndQuantity(OrderForUpdatingPriceAndQuantity order, int orderNumber);
    }
}
