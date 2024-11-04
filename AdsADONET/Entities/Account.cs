namespace AdsADONET.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public Account(int accountID, string accountName, string accountPassword, int personID, Person person)
        {
            AccountID = accountID;
            AccountName = accountName;
            AccountPassword = accountPassword;
            PersonID = personID;
            Person = person;
        }
    }
}
