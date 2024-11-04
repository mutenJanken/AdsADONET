using AdsADONET.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AdsADONET.Repository
{
    public class ListingRepo
    {
        public List<Listing> GetListings(string searchCondition, string filterCondition)
        {
            string query = "SELECT ListingID, Title, Price, ItemID, AccountID " +
                           "FROM Listings " +
                           "WHERE 1=1 ";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(searchCondition))
            {
                query += "AND Title LIKE @searchCondition ";
                parameters.Add(new SqlParameter("@searchCondition", "%" + searchCondition + "%"));
            }

            if (!string.IsNullOrEmpty(filterCondition))
            {
                query += "AND CategoryID = @filterCondition ";
                parameters.Add(new SqlParameter("@filterCondition", filterCondition));
            }

            DataTable result = DataContext.ExecuteQuery(query, parameters);

            List<Listing> listings = new List<Listing>();
            foreach (DataRow row in result.Rows)
            {
                listings.Add(new Listing
                {
                    ListingID = (int)row["ListingID"],
                    Title = (string)row["Title"],
                    Price = (decimal)row["Price"],
                    ItemID = (int)row["ItemID"],
                    AccountID = (int)row["AccountID"]
                });
            }
            return listings;
        }
    }
}
