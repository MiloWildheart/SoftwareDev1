using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyBooks.MVVM.Model
{
    public class MediaType
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Items> Items { get; set; }

        /**public int MediaID { get; }
        public string MediaName { get; }

        public readonly Items Type;

        public MediaType (int mediaID, string name, Items type){

            mediaID = MediaID;

            MediaName =  name;

            Type = type;

        }**/

    }
}
