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
            List <SqlParameter> parameters = new List <SqlParameter>();
            DataTable data = DataContext.ExecuteQuery(query, parameters);

            List<Category> categories = new List<Category>();
            foreach (DataRow row in data.Rows)
            {
                Category category = new Category((int) row["CategoryID"], (string)row["CategoryName"]);

                categories.Add(category);
            }
            return categories;
        }
    }
}
