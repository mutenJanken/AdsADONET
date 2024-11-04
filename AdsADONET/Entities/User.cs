using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsADONET.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public User(int userID, string userName, string userPassword, string fullName, string email)
        {
            UserID = userID;
            UserName = userName;
            UserPassword = userPassword;
            FullName = fullName;
            Email = email;
        }
    }
}
