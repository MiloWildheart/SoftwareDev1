using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using LibraryBooks.MVVM.Model;

namespace LibraryBooks.MVVM.ViewModel
{
    public class AuthorViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AuthorModel> authors { get; set; }
        public AuthorModel selectedAuthor;

        public ObservableCollection<AuthorModel> Authors
        {
            get { return authors; }
            set
            {
                if (authors != value)
                {
                    authors = value;
                    OnPropertyChanged(nameof(Authors));
                }
            }
        }

       

        private AuthorModel SelectedAuthor
        {
            get { return selectedAuthor; }
            set
            {
                if (selectedAuthor != value)
                {
                    selectedAuthor = value;
                    OnPropertyChanged(nameof(SelectedAuthor));
                }
            }
        }

        public ICommand AddCommand { get; set; }

        public AuthorViewModel()
        {
            Authors = new ObservableCollection<AuthorModel>();
        }

        public void AddAuthor(AuthorModel author)
        {
            Authors.Add(author);
            OnPropertyChanged("Authors");
        }

        public void DeleteAuthor(AuthorModel author)
        {
            Authors.Remove(author);
        }

        public void EditAuthor(AuthorModel author)
        {
            // Update the author in the collection
            int index = Authors.IndexOf(author);
            Authors[index] = author;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

   
    }
}