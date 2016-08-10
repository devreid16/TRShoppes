using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRShoppes.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string ProdDesc { get; set; }
        public int ProdQty { get; set; }
        public decimal ProdPrice { get; set; }

        public virtual Product Products { get; set; }       
        public virtual Customer Customer { get; set; }
    }
}