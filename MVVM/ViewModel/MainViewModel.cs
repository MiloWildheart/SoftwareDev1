using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MVVM.ViewModel
{
    /// <summary>
    /// ViewModel for the main window of the application
    /// </summary>
    class MainViewModel : ObservableObject
    {
        // ViewModel for the Home view
        public HomeViewModel HomeVM { get; set; }

        // Current view to display
        private object _currentView;

        public object currentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainViewModel()
        {
            // Create a new instance of the HomeViewModel
            HomeVM = new HomeViewModel();
            // Set the current view to the Home view
            currentView = HomeVM;
        }
    }
}
