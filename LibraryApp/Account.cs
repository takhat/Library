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
        # region Properties
        public int AccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
    }
}
