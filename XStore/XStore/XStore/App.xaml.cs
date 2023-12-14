using Syncfusion.Licensing;
using Syncfusion.SfBusyIndicator.XForms;
using Xamarin.Forms;
using XStoreApp.Autofac;
using XStoreApp.View;
using static AutoMapper.Internal.ExpressionFactory;

namespace XStoreApp
{
    public partial class App : Application
    {
        public App(AppSetup appSetup)
        {
            //SyncfusionLicenseProvider.RegisterLicense("MjYwOTEyMUAzMTM5MmUzNDJlMzBJeTBGZi9xaTkrSUpIU2RsOTMya3BLdmdqSEVrckx2M3lZTUFPL2NFVkpZPQ==;MjYwOTEyMkAzMTM5MmUzNDJlMzBQMGVNOU9MWGhoTmdYalZnMjFhSFBENHFaYW92clBDQjBtNW5LWlpuekpZPQ==;MjYwOTEyM0AzMTM5MmUzNDJlMzBBUDg4Y2Y5QW9VMmd2dkdmd2tUVDdDeW9rMFF0WWJsRDdZUmZmQ0VvVVZvPQ==;MjYwOTEyNEAzMTM5MmUzNDJlMzBDMUdTcTExcUFFenBhUGIxQmNXaFA5L0dLVXQ1ZThFdzh3UGxwT1VsaStZPQ==;MjYwOTEyNUAzMTM5MmUzNDJlMzBaL2dTZGU4LytjbWIzOTIrSGU0UDJ4akZvWUJ6R1hzbHhUdWloQlBlQXprPQ==;MjYwOTEyNkAzMTM5MmUzNDJlMzBBNjFqV0JCTFdXYmlqdGtvSFVpME5RL2tnc3hJSGk0dWViQnJHTm5jNUY4PQ==;MjYwOTEyN0AzMTM5MmUzNDJlMzBQRnNLbmFhQ1FYaUNXSzlLNGJUczh1cmlkUjRla0NZVmRwVm9HSy9SajZjPQ==;MjYwOTEyOEAzMTM5MmUzNDJlMzBLenlwSU5HM1dyaTlaUWF6NTFHNE1YTzFKNGJvWVBtUjgvSlF0SUpuMmZrPQ==;MjYwOTEyOUAzMTM5MmUzNDJlMzBsSVFxTmZYSlN3ejgrOVN5amdDRTIxZ1k2aFFycHg3ZTBRTUt0RlNnYjlRPQ==;MjYwOTEzMEAzMTM5MmUzNDJlMzBYcUdEam56Y2IzZWk3WDYxb01iSFJ2SmhweWU1clErdmNFb3VjQ29wYUJZPQ==;MjYwOTEzMUAzMTM5MmUzNDJlMzBXb3NjQnF3MlNzZEhGVW1BSlV3NUpYZWp0NlAraW8rOUV4eXVpUXk1Wm8wPQ==");
            SyncfusionLicenseProvider.RegisterLicense("MjU5NzUzNUAzMTM5MmUzNDJlMzBFSGdUdG40ZTRqekJhbm1vb0wxWm0xRTQxYTUxdVBBa1BpL0dzSFl4NHVJPQ==");
            InitializeComponent();
            
            AppContainer.Container = appSetup.CreateContainer();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
