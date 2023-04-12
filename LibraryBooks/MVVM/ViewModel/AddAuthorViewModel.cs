using LibraryBooks.MVVM.Model;
using LibraryBooks.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LibraryBooks.MVVM.Utility;

namespace LibraryBooks.MVVM.View
{
    public class AddAuthorViewModel : AuthorViewModel
    {
        private AuthorViewModel authorViewModel;
        private AddAuthorView addAuthorView;

        public AddAuthorViewModel(AddAuthorView addAuthorView)
        {
            this.addAuthorView = addAuthorView;
            AuthorViewModel = (AuthorViewModel)Application.Current.MainWindow.DataContext;
            AddCommand = new RelayCommand<object>(AddAuthor);
        }

        public string AuthorName { get; set; }
        public DateTime PublishingDate { get; set; }

        public ICommand AddCommand { get; set; }

        private void AddAuthor(object parameter)
        {
            AuthorModel newAuthor = new AuthorModel()
            {
                AuthorName = AuthorName,
                PublishingDate = PublishingDate.ToString("yyyy-MM-dd")
            };
            AuthorViewModel.AddAuthor(newAuthor);
            AddAuthorView.Close();
        }
    }
}