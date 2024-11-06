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
        public void CreateAccount(string username, string userPassword, string fullName, string email )
        {
            string query = "INSERT INTO Users(Username, Userpassword, Fullname, Email) VALUES(@Username, @Userpassword, @Fullname, @Email)" +
                            "SELECT CAST(@@identity as int)";

            SqlCommand cmd = new SqlCommand(query, DataContext.GetDbConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@Userpassword", userPassword);
            cmd.Parameters.AddWithValue("@Fullname", fullName);
            cmd.Parameters.AddWithValue("@Email", email);

            int id = (int)cmd.ExecuteScalar();

        }
    }
}
