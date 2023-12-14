using Autofac;
using AutoMapper;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XStore.Service;
using XStore.Service.ProductService;
using XStore.Service.UsersService;
using XStore.ServiceClient;
using XStoreApp.Autofac;
using XStoreApp.Models;

namespace XStoreApp.ViewModel
{
    public partial class PaymentViewModel : AbstractViewModel
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly AesEncryptionService _aesEncryptionService;
        private ObservableCollection<UserModel> _users = new ObservableCollection<UserModel>();
        public ObservableCollection<UserModel> Users
        {

            get { return _users; }
            set
            {
                if (_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        private string username;
        private string password;
        private bool isLoginEnabled;
        public PaymentViewModel()
        {
            _mapper = AppContainer.Container.Resolve<IMapper>();
            _productService = AppContainer.Container.Resolve<IProductService>();
            _userService = AppContainer.Container.Resolve<IUserService>();
            LoginCommand = new Command(ExecuteLogin);
            isLoginEnabled = true;
            Users = new ObservableCollection<UserModel>();
            _aesEncryptionService = new AesEncryptionService(GlobalConstants.encryptionKey);
        }

        public string Username
        {
            get => username;
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        private UserModel selectedUser;
        public UserModel SelectedUser
        {
            get { return selectedUser; }
            set
            {
                if (selectedUser != value)
                {
                    selectedUser = value;
                    OnPropertyChanged(nameof(SelectedUser));
                }
            }
        }
        public ICommand LoginCommand { get; }

        public bool IsLoginEnabled
        {
            get => isLoginEnabled;
            set
            {
                if (isLoginEnabled != value)
                {
                    isLoginEnabled = value;
                    OnPropertyChanged(nameof(IsLoginEnabled));
                }
            }
        }
        public async Task LoadUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                var data = _mapper.Map<ObservableCollection<UserModel>>(users);
                Users = data;
            }
            catch
            {
            }

        }
        private async void ExecuteLogin()
        { 
            bool isAuthenticated = await AuthenticateAsync(Username, Password);

            if (isAuthenticated)
            {
                
            }
            else
            {
                
            }
        }

        public async Task<bool>AuthenticateAsync(string username, string password)
        {
            var encryptedPassword = _aesEncryptionService.Encrypt(password);

            bool authenticated = await _userService.AuthenticateUserAsync(username, encryptedPassword);
            return authenticated;
        }
    }
}
