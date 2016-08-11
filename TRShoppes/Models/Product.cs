using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TRShoppes.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }       
        public long ProdUpc { get; set; }
        public string ProdDesc { get; set; }
        public int ProdQty { get; set; }
        public decimal ProdPrice { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
