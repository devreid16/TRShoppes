using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TRShoppes.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }   
        
        [DataType(DataType.DateTime)]   
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }        

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}