using AdsADONET.Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace AdsADONET.Repository
{
    public static class DataContext
    {

        public static SqlConnection GetDbConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnString"].ConnectionString);
        }

        public static DataTable ExecuteQuery(string query, List<SqlParameter> parameters)
        {
            
            using (SqlConnection conn = GetDbConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable result = new DataTable();
                conn.Open();
                adapter.Fill(result);
                return result;
            }
        }

        public static void ExecuteNonQuery(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = GetDbConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }
        }
        public static object ExecuteScalar(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = GetDbConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                return cmd.ExecuteScalar();
            }
        }
    }
}
