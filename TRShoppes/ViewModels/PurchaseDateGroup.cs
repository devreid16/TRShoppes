using System;
using System.ComponentModel.DataAnnotations;


namespace TRShoppes.ViewModels
{
    public class PurchaseDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        public int CustomerCount { get; set; }
    }

}