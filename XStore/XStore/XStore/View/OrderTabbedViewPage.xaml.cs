using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
    public partial class OrderTabbedViewPage : ContentPage
    {
        private static OrderTabbedViewModel _viewmodel = new OrderTabbedViewModel();
        private readonly static IMapper _mapper;

       

        private int currentIndex = 0;
        private ObservableCollection<OrderDetailsModel> _orderList = new ObservableCollection<OrderDetailsModel>();
       
        
        public OrderTabbedViewPage()
        {
            InitializeComponent();
            BindingContext = _viewmodel;
            if (_orderList.Count > 0)
            {
                UpdateOrderProperty();
            }
        }
        private void InitValues(OrdersModel ordersModel)
        {
            orderNumberShow.Text = "Order Number: " + ordersModel.orderNumber;
            orderDateShow.Text = "Order Date: " + ordersModel.orderDate;
            orderStatusShow.Text = "Order Status: " + ordersModel.orderStatus;
        }
        private async void button_searchNumber(object sender, EventArgs e)
        {
            var orderNumber = inputNumber.Text;
            int.TryParse(orderNumber, out int orderId);
            var orders = await _viewmodel.GetOrderByNumberViewModel(orderId);
            ObservableCollection<OrdersModel> ordersModel = new ObservableCollection<OrdersModel>(orders);
            InitValues(ordersModel[0]);
            await _viewmodel.GetOrderDetails(orderId);
            currentIndex = 0;
        }

        private  void NextButton_Clicked(object sender, EventArgs e)
        {

                if (_orderList.Count >= 0)
                {
                    currentIndex = (currentIndex + 1);
                }
                else
                {
                    currentIndex = 0;
                }
                UpdateOrderProperty();

        }


        private  void PreviousButton_Clicked(object sender, EventArgs e)
        {
            if (_orderList.Count >= 0)
                currentIndex = (currentIndex - 1);
            else
                currentIndex = 0;

            UpdateOrderProperty();
        }
        private async  void UpdateOrderProperty()
        {
            try
            {
                _viewmodel.OrderDetailsItem = _viewmodel.OrderDetails[currentIndex];
            }catch(ArgumentOutOfRangeException)
            {
                await DisplayAlert("Message", "No items available.", "OK");
            }
        }

        private async void updateValueButton_Clicked(object sender, EventArgs e)
        {
            var id = inputNumber.Text;
            int.TryParse(id, out int orderId);
            var price = priceUpdate.Text;
            decimal.TryParse(price, out decimal orderPrice);
            var quantity = quantityUpdate.Text;
            int.TryParse(quantity, out int orderQuantity);
            OrderForUpdatingPriceAndQuantityModel order = new OrderForUpdatingPriceAndQuantityModel { Price= orderPrice, Quantity= orderQuantity }; 
            await _viewmodel.UpdateOrderPriceAndQuantity(order,orderId);
        }
    }
}