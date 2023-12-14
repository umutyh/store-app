using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStore.ServiceClient;
using XStoreApp.ServiceClient;
using XStoreApp.ServiceClient.Models;

namespace XStore.Service.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly StoreAPI apiClient = new StoreAPI() { BaseUri = new Uri("http://10.0.2.2:5122/") };
        
        public OrderService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderInfoServiceDB>> GetAllOrdersInformation()
        {
            var orderInfo = await apiClient.GetOrderInformationWithHttpMessagesAsync();
            if(orderInfo.Response.IsSuccessStatusCode)
            {
                return orderInfo.Body.ToList();
            }
            return null;
        }   

        public async Task<IEnumerable<OrderDetailServiceDB>> GetAllOrdersDetails()
        {
            var orderDetail = await apiClient.GetOrderDetailsWithHttpMessagesAsync();
            if(orderDetail.Response.IsSuccessStatusCode)
            {
                return orderDetail.Body.ToList();
            }
            return null;
        }

        public async Task<List<OrderInfoServiceDB>> GetOrderByOrderNumber(int orderNumber)
        {
            var order = await apiClient.GetOrderByOrderNumberWithHttpMessagesAsync(orderNumber);
            if (order.Response.IsSuccessStatusCode)
            {
                if(order.Body == null)
                {
                    throw new Exception("Error");
                }
                return order.Body.ToList();
            }
            return null;
        }
        public async Task UpdatePriceAndQuantity(OrderForUpdatingPriceAndQuantity order, int orderNumber)
        {
            if(order == null)
            {
                throw new Exception();
            }
            await apiClient.UpdateOrderPriceAndQuantityWithHttpMessagesAsync(orderNumber,order);
        }
    }
}
