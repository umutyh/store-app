using Autofac;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XStore.Service.ProductService;
using XStoreApp.Autofac;
using XStoreApp.View;

namespace XStoreApp.ViewModel
{
    public partial class DetailsViewModel : AbstractViewModel
    {
        private readonly IProductService _productService;

        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get => _messages;
            set
            {
                if (_messages != value)
                {
                    _messages = value;
                    OnPropertyChanged(nameof(Messages));
                }
            }
        }

        public DetailsViewModel()
        {
            _productService = AppContainer.Container.Resolve<IProductService>();
            Messages = new ObservableCollection<string>();
            MessagingCenter.Subscribe<DetailsPage>(this, "Hi" , (sender) =>
            {
                Messages.Add("Price Increased");
            });
            MessagingCenter.Subscribe<DetailsPage, string>(this, "Price increased", (sender, arg) =>
            {
                Messages.Add("Price Increased " + arg);
            });
        }
        public async Task IncrementPrice(int id)
        {
            try
            {
                await _productService.IncreasingTheSearchedProduct(id);
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }

        }
    }
}
