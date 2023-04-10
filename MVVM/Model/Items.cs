using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyBooks.MVVM.Model
{
    public class Items
    {
        public int ItemID { get; }
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
        }
    }
}
