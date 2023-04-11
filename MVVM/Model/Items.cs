using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyBooks.MVVM.Model
{
    public class Items
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Authors Author { get; set; }
        public int MediaTypeId { get; set; }
        public virtual MediaType MediaType { get; set; }

        /**public int ItemID { get; }
        public string ItemName { get; }
        public string Description { get; }

        public readonly MediaType Type;

        public readonly Authors Authors;

        public Items (int itemID, string itemName, string description, MediaType type, Authors authors)
        {
            ItemID = itemID;
            ItemName = itemName;
            Description = description;
            Type = type;
            Authors = authors;
        }**/
    }
}
