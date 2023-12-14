using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XStoreApp.ViewModel
{
    public abstract class AbstractViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    OnPropertyChanged(nameof(IsBusy));
                }
            }
        }

        private bool isButtonVisible = true;
        public bool IsButtonVisible
        {
            get => isButtonVisible;
            set
            {
                if (isButtonVisible != value)
                {
                    isButtonVisible = value;
                    OnPropertyChanged(nameof(IsButtonVisible));
                }
            }
        }

        public string test()
        {
            return "test";
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
