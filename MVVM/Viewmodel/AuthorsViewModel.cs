using Microsoft.EntityFrameworkCore;
using LibararyBooks.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibararyBooks.MVVM.Utility;

namespace LibararyBooks.MVVM.ViewModel
{
    public class AuthorsViewModel : INotifyPropertyChanged
    {
        private readonly LibraryContext _context;
        private ObservableCollection<Authors> _authors;
        private string _newAuthorName;

        public ObservableCollection<Authors> Authors
        {
            get { return _authors; }
            set
            {
                _authors = value;
                OnPropertyChanged(nameof(Authors));
            }
        }

        public string NewAuthorName
        {
            get { return _newAuthorName; }
            set
            {
                _newAuthorName = value;
                OnPropertyChanged(nameof(NewAuthorName));
                AddAuthorCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand AddAuthorCommand { get; }

        public AuthorsViewModel()
        {
            _context = new LibraryContext();
            _context.Authors.Load();
            Authors = _context.Authors.Local.ToObservableCollection();

            AddAuthorCommand = new RelayCommand(
                () =>
                {
                    var author = new Authors { Name = NewAuthorName };
                    _context.Authors.Add(author);
                    _context.SaveChanges();
                    Authors.Add(author);
                    NewAuthorName = string.Empty;
                },
                () => !string.IsNullOrEmpty(NewAuthorName)
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}