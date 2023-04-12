using LibraryBooks.MVVM.Model;
using LibraryBooks.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryBooks.MVVM.Utility;


namespace LibraryBooks.MVVM.View
{
    /// <summary>
    /// Interaction logic for AddAuthorView.xaml
    /// </summary>
    public partial class AddAuthorView : Window
    {
        public AddAuthorView()
        {
            InitializeComponent();
            DataContext = new AddAuthorViewModel(this);
        }
    }

    public class AddAuthorViewModel : BaseViewModel
    {
        private AuthorViewModel authorViewModel;
        private AddAuthorView addAuthorWindow;

        public AddAuthorViewModel(AddAuthorView addAuthorView)
        {
            this.addAuthorView = addAuthorView;
            authorViewModel = (AuthorViewModel)Application.Current.MainWindow.DataContext;
            AddCommand = new RelayCommand(AddAuthor);
        }

        public string AuthorName { get; set; }
        public DateTime PublishingDate { get; set; }

        public ICommand AddCommand { get; set; }

        private void AddAuthor()
        {
            AuthorModel newAuthor = new AuthorModel()
            {
                AuthorName = AuthorName,
                PublishingDate = PublishingDate.ToString("yyyy-MM-dd")
            };
            authorViewModel.AddAuthor(newAuthor);
            AddAuthorView.Close();
        }
    }
}

