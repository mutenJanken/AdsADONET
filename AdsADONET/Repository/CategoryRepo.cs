using AdsADONET.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AdsADONET.Repository
{
    public class CategoryRepo
    {
        public List<Category> GetCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            List<SqlParameter> parameters = new List<SqlParameter>();
            DataTable data = DataContext.ExecuteQuery(query, parameters);

            List<Category> categories = new List<Category>();
            foreach (DataRow row in data.Rows)
            {
                Category category = new Category((int)row["CategoryID"], (string)row["CategoryName"]);

                categories.Add(category);
            }
            return categories;
        }
        public int GetCategoryID(string categoryName)
        {
            string query = "SELECT CategoryID FROM Categories WHERE CategoryName LIKE @categoryName";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@CategoryName", categoryName));

            int categoryID = (int)DataContext.ExecuteScalar(query, parameters);

            return categoryID;
        }
    }
}
