using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Book
    {
        public int Id { get; set; }  // Book ID

        public string BookName { get; set; } // Book name

        public string BookAuthor { get; set; } // Book author

        public int price { get; set; }  // price of book


    }
}