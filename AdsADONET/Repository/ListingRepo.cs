using AdsADONET.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AdsADONET.Repository
{
    public class ListingRepo
    {
        public List<Listing> GetListings(string searchCondition, string filterCondition, string sortBy)
        {
            string query = "SELECT ListingID, Title, ItemDescription, Price, ListingDate, Categories.CategoryID, CategoryName, Users.UserID, Username, UserPassword, FullName, Email " +
                           "FROM Listings " +
                           "INNER JOIN Categories ON Listings.CategoryID = Categories.CategoryID " +
                           "INNER JOIN Users ON Listings.UserID = Users.UserID " +
                           "WHERE 1=1 ";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(searchCondition))
            {
                query += "AND Title LIKE @searchCondition ";
                parameters.Add(new SqlParameter("@searchCondition", "%" + searchCondition + "%"));
            }
            if (!string.IsNullOrEmpty(filterCondition))
            {
                query += "AND Categories.CategoryName = @filterCondition ";
                parameters.Add(new SqlParameter("@filterCondition", filterCondition));
            }

            if (sortBy == "Price")
            {
                query += "ORDER BY Price asc";
            }
            else if (sortBy == "Date")
            {
                query += "ORDER BY ListingDate desc";
            }

            DataTable data = DataContext.ExecuteQuery(query, parameters);
            List<Listing> listings = new List<Listing>();
            foreach (DataRow row in data.Rows)
            {
                Category category = new Category((int)row["CategoryID"], row["CategoryName"].ToString());
                User user = new User((int)row["UserID"], row["Username"].ToString(), row["UserPassword"].ToString(), row["FullName"].ToString(), row["Email"].ToString());
                Listing listing = new Listing((int)row["ListingID"], row["Title"].ToString(), row["ItemDescription"].ToString(),
                                                (decimal)row["Price"], (DateTime)row["ListingDate"], category, user);
                listings.Add(listing);
            }
            return listings;
        }

        public bool CreateListing(string title, string itemDescription, string priceInText, int categoryID)
        {
            if (decimal.TryParse(priceInText, out decimal price))
            {
                string query = "INSERT INTO Listings(Title, ItemDescription, Price, ListingDate, UserID, CategoryID) VALUES (@Title, @ItemDescription, @Price, @ListingDate, @UserID, @CategoryID)";
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@Title", title));
                parameters.Add(new SqlParameter("@ItemDescription", itemDescription));
                parameters.Add(new SqlParameter("@Price", price));
                parameters.Add(new SqlParameter("@ListingDate", DateTime.Now));
                parameters.Add(new SqlParameter("@UserID", UserRepo.GetAccountID()));
                parameters.Add(new SqlParameter("@CategoryID", categoryID));

                DataContext.ExecuteDataEditQuery(query, parameters);

                return true;
            }
            return false;
        }
        public bool DeleteListing(int selecterdListingID, int selectedListingUserID)
        {
            int accountID = UserRepo.GetAccountID();

            if (selectedListingUserID == accountID)
            {
                string query = "DELETE FROM Listings WHERE ListingID = @ListingID AND UserID = @UserID";

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@ListingID", selecterdListingID));
                parameters.Add(new SqlParameter("@UserID", accountID));

                DataContext.ExecuteDataEditQuery(query, parameters);
                return true;
            }
            return false;
        }

        public bool UpdateListing(int selectedListingID, string title, string itemDescription, decimal price, int categoryID, int selectedListingUserID)
        {
            int accountID = UserRepo.GetAccountID();
            if (selectedListingUserID == accountID)
            {
                string query = "UPDATE Listings SET Title = @Title, ItemDescription = @ItemDescription, Price = @Price,  CategoryID = @CategoryID,  UserID = @UserID WHERE ListingID = @ListingID";
                List<SqlParameter> parameters = new List<SqlParameter>();                

                parameters.Add(new SqlParameter("@ListingID", selectedListingID));
                parameters.Add(new SqlParameter("@Title", title));
                parameters.Add(new SqlParameter("@ItemDescription", itemDescription));
                parameters.Add(new SqlParameter("@Price", price));
                parameters.Add(new SqlParameter("@CategoryID", categoryID));
                parameters.Add(new SqlParameter("@UserID", accountID));

                DataContext.ExecuteDataEditQuery(query, parameters);
                return true;
            }
            return false;
        }
    }
}
