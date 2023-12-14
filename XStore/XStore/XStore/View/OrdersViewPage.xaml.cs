using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.Models;
using XStoreApp.ViewModel;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersViewPage : ContentPage
    {
        private static OrdersViewModel _viewModel = new OrdersViewModel();
        public OrdersViewPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }
       
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.GetOrderInformation();
        }

        private async void orderInformationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var orderInformation = e.SelectedItem as OrdersModel;
            await Navigation.PushAsync(new OrderDetailsViewPage(orderInformation));
        }
    }
}