using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRShoppes.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ProductID { get; set; }
                
        public long ProdUpc { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string ProdDesc { get; set; }

        [Range(0, 50)]
        public int ProdQty { get; set; }

        [DataType(DataType.Currency)]
        public decimal ProdPrice { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }       
    }
}
