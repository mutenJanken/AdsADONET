using AdsADONET.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AdsADONET.Repository
{
    public class ListingRepo
    {
        public List<Listing> GetListings(string searchCondition, string filterCondition)
        {
            string query = "SELECT ListingID, Title, ItemDescription, Price, Categories.CategoryID, CategoryName, Users.UserID, Username, UserPassword, FullName, Email " +
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

            DataTable data = DataContext.ExecuteQuery(query, parameters);

            List<Listing> listings = new List<Listing>();
            foreach (DataRow row in data.Rows)
            {
                Category category = new Category((int)row["CategoryID"], row["CategoryName"].ToString());
                User user = new User((int)row["UserID"], row["Username"].ToString(), row["UserPassword"].ToString(), row["FullName"].ToString(), row["Email"].ToString());
                Listing listing = new Listing((int)row["ListingID"], row["Title"].ToString(), row["ItemDescription"].ToString(),
                                                (decimal)row["Price"], category, user);
                listings.Add(listing);
            }
            return listings;
        }

        public void CreateListing(string title, string itemDescription, string price)
        {
            Convert.ToDecimal(price);
            string query = "INSERT INTO Listings(Title, ItemDescription, Price) VALUES (@Title, @ItemDescription, @Price) " +
                "SELECT CAST(@@identity as int) ";
            using (SqlConnection conn = DataContext.GetDbConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@ItemDescription", itemDescription);
                cmd.Parameters.AddWithValue("@Price", price);

                int id = (int)cmd.ExecuteScalar();
            }
        }
    }
}
