using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XStore.Service.OrderService;
using XStoreApp.Autofac;
using XStoreApp.Models;

namespace XStoreApp.ViewModel
{
    public class OrderDetailsViewModel : AbstractViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private ObservableCollection<OrderDetailsModel> _orders = new ObservableCollection<OrderDetailsModel>();
        public ObservableCollection<OrderDetailsModel> OrderDetails
        {

            get { return _orders; }
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    OnPropertyChanged(nameof(OrderDetails));
                }
            }
        }
        public OrderDetailsViewModel()
        {
            _mapper = AppContainer.Container.Resolve<IMapper>();
            _orderService = AppContainer.Container.Resolve<IOrderService>();
            OrderDetails = new ObservableCollection<OrderDetailsModel>();
        }
    }
}
