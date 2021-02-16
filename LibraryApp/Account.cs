using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    /// <summary>
    /// This represents a library account where you can access library books
    /// </summary>
    public class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        public int AccountNumber { get; private set; } //set is only available to the scope of this class
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public int NumberOfHolds { get; private set; } //set is only available to the scope of this class
        public string Book1ISBN { get; set; }
        public DateTime Book1DueDate { get; set; }
        public string Book2ISBN { get; set; }
        public DateTime Book2DueDate { get; set; }
        public string Book3ISBN { get; set; }
        public DateTime Book3DueDate { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Place a hold on a library book
        /// </summary>
        /// <param name="ISBN"></param>
        public void PlaceHold(string ISBN)
        {
            //if(NumberOfCopiesAvailableForHold > 0 && NumberOfHolds<3) { 
                NumberOfHolds++;
                Book1ISBN = ISBN;
                Book1DueDate = DateTime.UtcNow; //fix it
            //}
        }
        /// <summary>
        /// Return a library book
        /// </summary>
        /// <param name="ISBN"></param>
        public void ReturnBook(string ISBN)
        {
            NumberOfHolds--;
            Book1ISBN = ISBN;
        }


        #endregion
        #region Constructor
        public Account()
        {
            AccountNumber= ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
        }
        #endregion
    }
}
