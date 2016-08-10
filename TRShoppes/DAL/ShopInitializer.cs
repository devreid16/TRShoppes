using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRShoppes.Models;

namespace TRShoppes.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstName="Carson",LastName="Alexander",PurchaseDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Meredith",LastName="Alonso",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Arturo",LastName="Anand",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstName="Gytis",LastName="Barzdukas",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Yan",LastName="Li",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Peggy",LastName="Justice",PurchaseDate=DateTime.Parse("2001-09-01")},
            new Customer{FirstName="Laura",LastName="Norman",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstName="Nino",LastName="Olivetto",PurchaseDate=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
            new Product{ProductID=1050,ProdUpc=022255588890,ProdDesc="Coats",ProdQty=30,ProdPrice=100.00m },
            new Product{ProductID=4022,ProdUpc=033366699900,ProdDesc="Blouses",ProdQty=23,ProdPrice=20.00m },
            new Product{ProductID=4041,ProdUpc=044455566670,ProdDesc="TShirts",ProdQty=43,ProdPrice=10.00m },
            new Product{ProductID=1045,ProdUpc=055566677780,ProdDesc="Shoes",ProdQty=45,ProdPrice=50.00m },
            new Product{ProductID=3141,ProdUpc=066677788890,ProdDesc="Pants",ProdQty=24,ProdPrice=30.00m },
            new Product{ProductID=2021,ProdUpc=077788899000,ProdDesc="Skirts",ProdQty=33,ProdPrice=25.00m }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();            

            var purchases = new List<Purchase>
            {
            new Purchase{PurchaseID=1,ProductID=1050,ProdQty=1 },
            new Purchase{PurchaseID=2,ProductID=4022,ProdQty=2 },
            new Purchase{PurchaseID=3,ProductID=4041,ProdQty=4 },
            new Purchase{PurchaseID=4,ProductID=1045,ProdQty=1 },
            new Purchase{PurchaseID=5,ProductID=3141,ProdQty=2 },
            new Purchase{PurchaseID=6,ProductID=2021,ProdQty=1 },
            new Purchase{PurchaseID=7,ProductID=1050,ProdQty=1 },
            new Purchase{PurchaseID=8,ProductID=1050,ProdQty=1 },
            new Purchase{PurchaseID=9,ProductID=4022,ProdQty=2 },
            new Purchase{PurchaseID=1,ProductID=4041,ProdQty=3 },
            new Purchase{PurchaseID=1,ProductID=1045,ProdQty=2 },
            new Purchase{PurchaseID=1,ProductID=3141,ProdQty=2 }
            };

            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();
        }
    }
}