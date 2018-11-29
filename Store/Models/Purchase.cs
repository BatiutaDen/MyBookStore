using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; } 

        public string Person { get; set; } // Name of person

        public string Address { get; set; } //  address of person

        public int BookId { get; set; }  // book ID

        public DateTime PurchaseDate { get; set; } // 
    


    }
}