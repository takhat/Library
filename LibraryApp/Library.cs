using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public static class Library
    {
        public static Account CreateAccount(string emailAddress)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
            };
            return account;
        }
        public static Account CreateAccount(string emailAddress, 
            string holdBookISBN1)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                Book1ISBN = holdBookISBN1,
            };
            return account;
        }
        public static Account CreateAccount(string emailAddress,
            string holdBookISBN1,
            string holdBookISBN2)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                Book1ISBN = holdBookISBN1,
                Book2ISBN = holdBookISBN2,
            };
            return account;
        }
        public static Account CreateAccount(string emailAddress,
            string holdBookISBN1,
            string holdBookISBN2,
            string holdBookISBN3)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                Book1ISBN = holdBookISBN1,
                Book2ISBN = holdBookISBN2,
                Book3ISBN = holdBookISBN3
            };
            return account;
        }
    }
}
