using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStore.Service.OrderService;
using XStoreApp.Autofac;
using XStoreApp.Models;
using XStoreApp.ServiceClient.Models;

namespace XStoreApp.ViewModel
{
    public class OrderTabbedViewModel : AbstractViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        private ObservableCollection<OrdersModel> _orders;
        public ObservableCollection<OrdersModel> Orders
        {
            get { return _orders; }
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    OnPropertyChanged(nameof(Orders));
                }
            }
        }

        private ObservableCollection<OrderDetailsModel> _ordersDetails;
        public ObservableCollection<OrderDetailsModel> OrderDetails
        {

            get { return _ordersDetails; }
            set
            {
                if (_ordersDetails != value)
                {
                    _ordersDetails = value;
                    OnPropertyChanged(nameof(OrderDetails));
                }
            }
        }

        private OrderDetailsModel _orderItem = new OrderDetailsModel();
        public OrderDetailsModel OrderDetailsItem
        {

            get { return _orderItem; }
            set
            {
                if (_orderItem != value)
                {
                    _orderItem = value;
                    OnPropertyChanged(nameof(OrderDetailsItem));
                }
            }
        }

        public OrderTabbedViewModel()
        {
            _orderService = AppContainer.Container.Resolve<IOrderService>();
            _mapper = AppContainer.Container.Resolve<IMapper>();
            Orders = new ObservableCollection<OrdersModel>();
            OrderDetails = new ObservableCollection<OrderDetailsModel>();
        }
        public async Task<List<OrdersModel>> GetOrderByNumberViewModel(int orderNumber)
        {
            var data = await _orderService.GetOrderByOrderNumber(orderNumber);
            var orders = _mapper.Map<List<OrdersModel>>(data);
            var observable = new ObservableCollection<OrdersModel>(orders);
            return _mapper.Map<List<OrdersModel>>(observable);
         }
        public async Task GetOrderDetails(int orderNumber)
        {
            var data = (await _orderService.GetAllOrdersDetails()).Where(x => x.OrderNumber == orderNumber).ToList<OrderDetailServiceDB>();
            var orders = _mapper.Map<IEnumerable<OrderDetailsModel>>(data);
            OrderDetails = new ObservableCollection<OrderDetailsModel>(orders);
            if (OrderDetails.Count != 0)
            {
                OrderDetailsItem = OrderDetails[0];
            }
        }
        public async Task UpdateOrderPriceAndQuantity(OrderForUpdatingPriceAndQuantityModel order,int orderNumber)
        {
            if(order == null)
            {
                throw new Exception("Error");
            }
            var mappedData = _mapper.Map<OrderForUpdatingPriceAndQuantity>(order);
            await _orderService.UpdatePriceAndQuantity(mappedData, orderNumber);
        }
        
    }
}
