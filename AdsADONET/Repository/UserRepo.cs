using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdsADONET.Repository
{
    public class UserRepo
    {
        public string CreateAccount(string username, string userPassword, string fullName, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                return "Failed to create account, fill each box with account information.";
            }
            else
            {
                string query = "INSERT INTO Users(Username, Userpassword, Fullname, Email) VALUES(@Username, @Userpassword, @Fullname, @Email)" +
                                "SELECT CAST(@@identity as int)";
                using (SqlConnection conn = DataContext.GetDbConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@Userpassword", userPassword);
                    cmd.Parameters.AddWithValue("@Fullname", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();
                    int id = (int)cmd.ExecuteScalar();
                }
                return "Account has been created.";
            }
        }
        public void ValidateUser(string username, string userPassword)
        {
            string query = "SELECT UserID, Username, UserPassword from Users WHERE Username = @username AND UserPassword = @userPassword";

            using (SqlConnection conn = DataContext.GetDbConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@UserPassword", userPassword);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
            }             

        }
    }
}
