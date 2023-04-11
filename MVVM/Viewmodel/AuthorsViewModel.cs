
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
    public class AuthorsViewModel
    {
        private readonly LibraryContext _context;

        public ObservableCollection<Authors> Authors { get; } = new ObservableCollection<Authors>();
        public string NewAuthorName { get; set; }

        public RelayCommand AddAuthorCommand { get; }

        public AuthorsViewModel()
        {
            _context = new LibraryContext();
            _context.Authors.Load();
            Authors.AddRange(_context.Authors.Local.ToObservableCollection());

            AddAuthorCommand = new RelayCommand(
                () =>
                {
                    var author = new Authors { Name = NewAuthorName };
                    _context.Authors.Add(author);
                    _context.SaveChanges();
                    Authors.Add(author);
                },
                () => !string.IsNullOrEmpty(NewAuthorName)
            );
        }
    }
}
