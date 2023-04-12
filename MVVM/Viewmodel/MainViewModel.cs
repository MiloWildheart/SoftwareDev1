using LibararyBooks.MVVM.Utility;
using LibararyBooks.MVVM.ViewModel;
using System.ComponentModel;
using System.Windows.Input;

namespace LibararyBooks.MVVM.Viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentViewModel;

        public ICommand NavigateToAuthorsCommand { get; private set; }

        public ICommand NavigateToItemsCommand { get; private set; }

        public ICommand NavigateToMediaTypesCommand { get; private set; }

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentViewModel)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            NavigateToAuthorsCommand = new RelayCommand(NavigateToAuthors);
            NavigateToItemsCommand = new RelayCommand(NavigateToItems);
            NavigateToMediaTypesCommand = new RelayCommand(NavigateToMediaTypes);

            CurrentViewModel = new AuthorsViewModel();
        }

        private void NavigateToAuthors()
        {
            CurrentViewModel = new AuthorsViewModel();
        }

        private void NavigateToItems()
        {
            CurrentViewModel = new ItemsViewModel();
        }

        private void NavigateToMediaTypes()
        {
            CurrentViewModel = new MediaTypesViewModel();
        }
    }
}