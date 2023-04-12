using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using LibraryBooks.MVVM.Model;

namespace LibraryBooks.MVVM.ViewModel
{
    internal class AuthorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AuthorModel> authors;
        private AuthorModel selectedAuthor;

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

        public AuthorModel SelectedAuthor
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

        public AuthorViewModel()
        {
            Authors = new ObservableCollection<AuthorModel>();
        }

        public void AddAuthor(AuthorModel author)
        {
            Authors.Add(author);
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

        internal static void DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        internal static void EditAuthor()
        {
            throw new NotImplementedException();
        }

        internal static void AddAuthor()
        {
            throw new NotImplementedException();
        }
    }
}