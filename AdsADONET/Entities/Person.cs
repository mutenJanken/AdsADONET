using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsADONET.Entities
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }

        public Person(int personID, string firstName, string lastName, string email, string homeAddress, string phone, string postalCode)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HomeAddress = homeAddress;
            Phone = phone;
            PostalCode = postalCode;
        }
    }
}
