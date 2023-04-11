using Microsoft.EntityFrameworkCore;
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
    public class ItemsViewModel : INotifyPropertyChanged
    {
        private readonly LibraryContext _context;
        private ObservableCollection<Items> _items;
        private Items _selectedItem;

        public ObservableCollection<Items> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public Items SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public ItemsViewModel()
        {
            _context = new LibraryContext();
            Items = new ObservableCollection<Items>(_context.Items.Include(i => i.Author).Include(i => i.MediaType));
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void AddItem(Items item)
        {
            Items.Add(item);
            _context.Items.Add(item);
            SaveChanges();
        }

        public void UpdateItem(Items item)
        {
            _context.Entry(item).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteItem(Items item)
        {
            Items.Remove(item);
            _context.Items.Remove(item);
            SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
