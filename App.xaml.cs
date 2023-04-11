using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LibararyBooks.MVVM.Model;
using Microsoft.EntityFrameworkCore;

namespace LibararyBooks
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (var db = new LibraryContext())
            {
                db.Database.Migrate();
            }
        }
    }
}
