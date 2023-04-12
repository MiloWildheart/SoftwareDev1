using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.MVVM.Model
{
    internal class AuthorModel : INotifyPropertyChanged
    {
        private string authorID;
        private string authorName;
        private string publishingDate;

        public string AuthorID
        {
            get { return authorID; }
            set
            {
                if (authorID != value)
                {
                    authorID = value;
                    OnPropertyChanged(nameof(AuthorID));
                }
            }
        }

        public string AuthorName
        {
            get { return authorName; }
            set
            {
                if (authorName != value)
                {
                    authorName = value;
                    OnPropertyChanged(nameof(AuthorName));
                }
            }
        }

        public string PublishingDate
        {
            get { return publishingDate; }
            set
            {
                if (publishingDate != value)
                {
                    publishingDate = value;
                    OnPropertyChanged(nameof(PublishingDate));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}