using Syncfusion.SfBusyIndicator.XForms;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XStoreApp.View;
using XStoreApp.ViewModel;

namespace XStoreApp
{
    public partial class MainPage : ContentPage
    {
        private static MainPageViewModel _viewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }

        private async void productPageButton_Clicked(object sender, System.EventArgs e)
        {
            //var viewModel = BindingContext as AbstractViewModel;
            if (_viewModel.IsBusy)
                return;

            _viewModel.IsBusy = true;
            busyindicator.IsVisible = true;

            await Task.Delay(3000);

            _viewModel.IsBusy = false;
            busyindicator.IsVisible = false;

            await Navigation.PushAsync(new ProductsPage());
        }

    }
}
