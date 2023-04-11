using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyBooks.MVVM.Model
{
    public class Authors
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Items> Items { get; set; }

       // public readonly Items _AuthorName;

        //public string AuthorName { get; }

//        public Authors (string name)
        //{
  //          AuthorName = name;
    //        _AuthorName = new Items();
      //  }
    }
}
