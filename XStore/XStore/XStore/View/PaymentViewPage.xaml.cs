using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.ViewModel;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentViewPage : ContentPage
    {
        private static PaymentViewModel _paymentViewModel = new PaymentViewModel();
        public PaymentViewPage()
        {
            InitializeComponent();
            BindingContext = _paymentViewModel;
        }
        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            string selectedUser = username.Text;
            string enteredPassword = password.Text;

            bool loginSuccessful = await _paymentViewModel.AuthenticateAsync(selectedUser, enteredPassword);
            if (loginSuccessful)
            {
                await DisplayAlert("Success", "Login successful!", "OK");
                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await DisplayAlert("Error", "Login failed. Invalid credentials.", "OK");
            }
        }
    }
}
