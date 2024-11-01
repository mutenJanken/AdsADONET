using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsADONET.Entities
{
    public class Listing
    {
        public int ListingID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        public int AccountID { get; set; }
        public Account Account { get; set; }

        public Listing(int listingID, string title, decimal price, int itemID, Item item, int accountID, Account account)
        {
            ListingID = listingID;
            Title = title;
            Price = price;
            ItemID = itemID;
            Item = item;
            AccountID = accountID;
            Account = account;
        }
    }
}
