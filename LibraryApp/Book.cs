using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public int NumberOfCopiesTotal { get; set; }
        public int NumberOfCopiesAvailableForHold { get; set; }
    }
}
