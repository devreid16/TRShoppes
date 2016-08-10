using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TRShoppes.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }        
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

        [DisplayFormat(NullDisplayText = "None")]
        public int? ProdQty { get; set; }
        

        public virtual Product Product { get; set; }       
        public virtual Customer Customer { get; set; }
    }
}