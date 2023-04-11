using System.Data.Entity;
using LibararyBooks.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyBooks.MVVM.ViewModel
{
    public class MediaTypesViewModel : INotifyPropertyChanged
    {
        private readonly LibraryContext _context;
        private ObservableCollection<MediaType> _mediaTypes;

        public ObservableCollection<MediaType> MediaTypes
        {
            get => _mediaTypes;
            set
            {
                _mediaTypes = value;
                OnPropertyChanged(nameof(MediaTypes));
            }
        }

        public MediaTypesViewModel()
        {
            _context = new LibraryContext();
            MediaTypes = new ObservableCollection<MediaType>(_context.MediaTypes);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
