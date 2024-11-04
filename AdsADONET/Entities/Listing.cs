namespace AdsADONET.Entities
{
    public class Listing
    {
        public int ListingID { get; set; }
        public string Title { get; set; }
        public string ItemDescription { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public User User {  get; set; }

        public Listing(int listingID, string title, string itemDescription, decimal price, Category category, User user)
        {
            ListingID = listingID;
            Title = title;
            ItemDescription = itemDescription;
            Price = price;
            Category = category;
            User = user;
        }
    }
}
