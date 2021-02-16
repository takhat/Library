using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = Library.CreateAccount("test@email.com", "978-1-4504-0024-4");

            Console.WriteLine($"AN:{myAccount.AccountNumber}, Email:{myAccount.EmailAddress}, Book On Hold:{myAccount.Book1ISBN}");
        }
    }
}
