using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.Models;
using XStoreApp.ServiceClient.Models;
using XStoreApp.ViewModel;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetailsViewPage : ContentPage
    {
        private static OrderDetailsViewModel _viewModel = new OrderDetailsViewModel();
        public OrderDetailsViewPage(OrdersModel orderModel)
        {
            InitializeComponent();
            InitValues(orderModel);
            BindingContext = _viewModel;
        }
        
        private void InitValues(OrdersModel orderModel)
        {
            orderNumberShow.Text = "Order Number:" + orderModel.orderNumber;
            orderDateShow.Text = "Order Date:" + orderModel.orderDate;
            orderStatusShow.Text = "Order Status: " + orderModel.orderStatus;            
        }
    }
}