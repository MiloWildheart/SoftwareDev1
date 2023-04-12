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
using LibraryBooks.MVVM.ViewModel;

namespace LibraryBooks.MVVM.View
{
    /// <summary>
    /// Interaction logic for AuthorView.xaml
    /// </summary>
    public partial class AuthorView : UserControl
    {
        public AuthorView()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAuthorView addAuthorWindow = new AddAuthorView();
            addAuthorView.ShowDialog();
        }


        private void Edit_Click(object sender, RoutedEventArgs e) => AuthorViewModel.EditAuthor();

        private void Delete_Click(object sender, RoutedEventArgs e) => AuthorViewModel.DeleteAuthor();
        
    }
}
