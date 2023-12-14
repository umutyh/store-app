using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.Models;
using XStoreApp.ViewModel;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        private static DetailsViewModel _viewModel = new DetailsViewModel();

        public DetailsPage(ProductModel prodDetails)
        {
            InitializeComponent();
            BindingContext = _viewModel;
            InitValues(prodDetails);
            MessagingCenter.Subscribe<DetailsPage, string>(this, "Information", async (sender, arg) =>
            {
                await DisplayAlert("Price increased", "arg=" + arg, "OK");
            });
        }

        private async void InitValues(ProductModel prodDetails)
        {
            await _viewModel.IncrementPrice(prodDetails.productId);
            productNameShow.Text = "Product Name:" + prodDetails.productName;
            productIdShow.Text = "ID:" + prodDetails.productId;
            productPriceShow.Text = "Price: " + prodDetails.Price;
        }

        private async void paymentPageButton_Clicked(object sender, EventArgs e)
        {
            //MessagingCenter.Send<DetailsPage>(this, productIdShow.ToString());
            if (_viewModel.IsBusy)
                return;

            _viewModel.IsBusy = true;
            busyindicator.IsVisible = true;

            await Task.Delay(3000);

            await Navigation.PushAsync(new PaymentViewPage());

            busyindicator.IsVisible = false;
            _viewModel.IsBusy = false;
        }
    }
}