using AutoMapper;
using store.Database.Models;
using store.Database.OrderRepository;
using store.Database.UserRepository;
using store.Service.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Service.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repoOrder;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository repoOrder, IMapper mapper)
        {
            _repoOrder = repoOrder;
            _mapper = mapper;
        }
        public async Task<List<OrderInfoServiceDB>> GetAllOrdersInformation()
        {
            return _mapper.Map<List<OrderInfoServiceDB>>(await _repoOrder.GetAllOrdersAsync());
        }

        public async Task<List<OrderDetailServiceDB>> GetAllOrdersDetails()
        {
            return _mapper.Map<List<OrderDetailServiceDB>>(await _repoOrder.GetAllOrderDetailsAsync());
        }

        public async Task<OrderInfoServiceDB> CreateOrderInfo(OrderInfoCreation orderCreation)
        {
            var mappedData = _mapper.Map<Orders>(orderCreation);
            if (mappedData == null)
            {
                throw new Exception("Error");
            }
            var createdData = _mapper.Map<OrderInfoServiceDB>(await _repoOrder.CreateOrder(mappedData));
            return createdData;
        }

        public async Task<OrderDetailServiceDB> CreateOrderDet(OrderDetailCreation orderDetailCreation)
        {
            var mappedData = _mapper.Map<OrderDetails>(orderDetailCreation);
            if (mappedData == null)
            {
                throw new Exception("Error");
            }
            var createdData = _mapper.Map<OrderDetailServiceDB>(await _repoOrder.CreateOrderDetails(mappedData));
            return createdData;
        }
        public async Task<List<OrderDetailsCombined>> GetOrdersCombined()
        {
            var data = await _repoOrder.GetOrdersCombinedTable();
            return _mapper.Map<List<OrderDetailsCombined>>(data);
        }

        public async Task<List<OrderInfoServiceDB>> OrderByOrderNumber(int orderNumber)
        {
            var data = await _repoOrder.GetOrderByNumber(orderNumber);
            var mappedData = _mapper.Map<List<OrderInfoServiceDB>>(data);
            if(mappedData == null)
            {
                throw new Exception("Error");
            }
            return mappedData;
        }

        public async Task<OrderDetailServiceDB> UpdateOrderPrice(OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber)
        {
            if(orderDetail == null)
            {
                throw new Exception();
            }
            var mapped = _mapper.Map<OrderDetails>(orderDetail);
            return _mapper.Map<OrderDetailServiceDB>(await _repoOrder.updateOrderPriceAndQuantity(mapped, orderNumber));
        }

        public async Task UpdateOrderRow(OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber)
        {
            if (orderDetail == null)
            {
                throw new Exception();
            }
            var mapped = _mapper.Map<OrderDetails>(orderDetail);
            
            await _repoOrder.updateOrderRow(mapped, orderNumber);
        }
    }
}
