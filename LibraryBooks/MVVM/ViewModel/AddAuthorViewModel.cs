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
using LibraryBooks.MVVM.View;

namespace LibraryBooks.MVVM.ViewModel
{
    public class AddAuthorViewModel2 : AuthorViewModel
    {
        private AuthorViewModel authorViewModel;
        private AddAuthorView addAuthorView;

        public AddAuthorViewModel2(AddAuthorView addAuthorView)
        {
            this.addAuthorView = addAuthorView;
            AuthorViewModel = (AuthorViewModel)Application.Current.MainWindow.DataContext;
            AddCommand = new RelayCommand(AddAuthor);
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
            addAuthorView.Close();
        }
    }
}