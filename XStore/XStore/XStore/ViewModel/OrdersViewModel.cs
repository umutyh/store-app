using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XStore.Service.ProductService;
using XStore.Service.UsersService;
using XStore.Service;
using XStoreApp.Models;
using XStore.Service.OrderService;
using AutoMapper;
using XStoreApp.Autofac;
using XStoreApp.ServiceClient.Models;
using Autofac;
using System.Threading.Tasks;
using System.Linq;

namespace XStoreApp.ViewModel
{
    public class OrdersViewModel : AbstractViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private ObservableCollection<OrdersModel> _orders= new ObservableCollection<OrdersModel>();
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
        public OrdersViewModel()
        {
            _mapper = AppContainer.Container.Resolve<IMapper>();
            _orderService = AppContainer.Container.Resolve<IOrderService>();
            Orders = new ObservableCollection<OrdersModel>();
        }

        public async Task GetOrderInformation()
        {
            var orderInformation = await _orderService.GetAllOrdersInformation();
            var mapped = _mapper.Map<ObservableCollection<OrdersModel>>(orderInformation);
                Orders = mapped;
        }

        

    }
}
