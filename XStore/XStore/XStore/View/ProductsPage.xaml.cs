using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.Models;
using XStoreApp.ViewModel;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        private static ProductViewModel _viewModel=new ProductViewModel();
        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.GetProducts();
        }

        private async void productListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var productDetails = e.SelectedItem as ProductModel;            
            await Navigation.PushAsync(new DetailsPage(productDetails));
        }
    }
}