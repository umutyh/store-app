using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XStoreApp.Models;

namespace XStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

       

        private async void listPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrdersViewPage()) ;
        }

        private async void tabbedMenu_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderTabbedViewPage());
        }
    }
}