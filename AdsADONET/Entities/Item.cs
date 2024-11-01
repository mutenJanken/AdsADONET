using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsADONET.Entities
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemDescription { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public Item(int itemID, string itemDescription, int categoryID, Category category)
        {
            ItemID = itemID;
            ItemDescription = itemDescription;
            CategoryID = categoryID;
            Category = category;
        }
    }
}
