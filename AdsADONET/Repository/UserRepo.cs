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
        private static int accountID;
        private static string accountName;
        public string CreateAccount(string username, string userPassword, string fullName, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                return "Missing info. You need to fill each box with account information.";
            }
            else
            {
                string query = "INSERT INTO Users(Username, Userpassword, Fullname, Email) VALUES(@Username, @Userpassword, @Fullname, @Email)" +
                                "SELECT CAST(@@identity as int)";

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@Username", username));
                parameters.Add(new SqlParameter("@Userpassword", userPassword));
                parameters.Add(new SqlParameter("@Fullname", fullName));
                parameters.Add(new SqlParameter("@Email", email));

                DataContext.ExecuteDataEditQuery(query, parameters);

                return "Account has been created.";
            }
        }
        public bool ValidateUser(string username, string userPassword)
        {
            string query = "SELECT UserID, Username, UserPassword from Users WHERE Username = @username AND UserPassword = @userPassword";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@Username", username));
            parameters.Add(new SqlParameter("@UserPassword", userPassword));

            accountID = (int)DataContext.ExecuteScalar(query, parameters);
            if (accountID > 0)
            {
                accountName = username;
                return true;
            }
            return false;
        }
        public static int GetAccountID()
        {
            return accountID;
        }
        public static string GetAccountName()
        {
            return accountName;
        }
        public static void SetAccountIDToZero()
        {
            accountID = 0;
        }
    }
}
