namespace TRShoppes.Migrations
{
    using TRShoppes.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TRShoppes.DAL.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TRShoppes.DAL.ShopContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { FirstName = "Carson",   LastName = "Alexander",
                    PurchaseDate = DateTime.Parse("2010-09-01") },
                new Customer { FirstName = "Meredith", LastName = "Alonso",
                    PurchaseDate = DateTime.Parse("2012-09-01") },
                new Customer { FirstName = "Arturo",   LastName = "Anand",
                    PurchaseDate = DateTime.Parse("2013-09-01") },
                new Customer { FirstName = "Gytis",    LastName = "Barzdukas",
                    PurchaseDate = DateTime.Parse("2012-09-01") },
                new Customer { FirstName = "Yan",      LastName = "Li",
                    PurchaseDate = DateTime.Parse("2012-09-01") },
                new Customer { FirstName = "Peggy",    LastName = "Justice",
                    PurchaseDate = DateTime.Parse("2011-09-01") },
                new Customer { FirstName = "Laura",    LastName = "Norman",
                    PurchaseDate = DateTime.Parse("2013-09-01") },
                new Customer { FirstName = "Nino",     LastName = "Olivetto",
                    PurchaseDate = DateTime.Parse("2005-08-11") }
            };
            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { EmpFirstName = "Kim",     EmpLastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11") },
                new Employee { EmpFirstName = "Fadi",    EmpLastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06") },
                new Employee { EmpFirstName = "Roger",   EmpLastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01") },
                new Employee { EmpFirstName = "Candace", EmpLastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15") },
                new Employee { EmpFirstName = "Roger",   EmpLastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12") }
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.EmpLastName, s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { Name = "Shoes", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    EmployeeID  = employees.Single( i => i.EmpLastName == "Abercrombie").ID },
                new Department { Name = "Mens", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    EmployeeID  = employees.Single( i => i.EmpLastName == "Fakhouri").ID},
                new Department { Name = "Womens", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    EmployeeID  = employees.Single( i => i.EmpLastName == "Harui").ID },
                new Department { Name = "Sportswear",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    EmployeeID  = employees.Single( i => i.EmpLastName == "Kapoor").ID }
            };
            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var product = new List<Product>
            {
                new Product{ProductID = 1050, ProdUpc = 022255588890, ProdDesc ="Coats",  ProdQty = 30, ProdPrice = 100.00m },
                new Product{ProductID = 4022, ProdUpc = 033366699900, ProdDesc ="Blouses",ProdQty = 23, ProdPrice = 20.00m },
                new Product{ProductID = 4041, ProdUpc = 044455566670, ProdDesc ="TShirts",ProdQty = 43, ProdPrice = 10.00m },
                new Product{ProductID = 1045, ProdUpc = 055566677780, ProdDesc ="Shoes",  ProdQty = 45, ProdPrice = 50.00m },
                new Product{ProductID = 3141, ProdUpc = 066677788890, ProdDesc ="Pants",  ProdQty = 24, ProdPrice = 30.00m },
                new Product{ProductID = 2021, ProdUpc = 077788899000, ProdDesc ="Skirts", ProdQty = 33, ProdPrice = 25.00m }
            };
            product.ForEach(s => context.Products.AddOrUpdate(p => p.ProdDesc, s));
            context.SaveChanges();

            var Purchases = new List<Purchase>
            {
                new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Alexander").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Coats" ).ProductID,
                    ProdQty = 1
                },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Alexander").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Blouses" ).ProductID,
                    ProdQty = 2
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Alexander").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "TShirts" ).ProductID,
                    ProdQty = 4
                 },
                 new Purchase {
                     CustomerID = customers.Single(s => s.LastName == "Alonso").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Pants" ).ProductID,
                    ProdQty = 1
                 },
                 new Purchase {
                     CustomerID = customers.Single(s => s.LastName == "Alonso").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc ==  "TShirts" ).ProductID,
                    ProdQty = 2
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Alonso").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Shoes" ).ProductID,
                    ProdQty = 1
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Anand").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Pants" ).ProductID
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Anand").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Skirts" ).ProductID,
                    ProdQty = 1
                 },
                new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Barzdukas").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Pants" ).ProductID,
                   ProdQty = 1
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Li").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "Shoes" ).ProductID,
                    ProdQty = 2
                 },
                 new Purchase {
                    CustomerID = customers.Single(s => s.LastName == "Justice").CustomerID,
                    ProductID = product.Single(c => c.ProdDesc == "TShirts" ).ProductID,
                    ProdQty = 3
                 }
            };

            foreach (Purchase e in Purchases)
            {
                var PurchaseInDataBase = context.Purchases.Where(
                    s =>
                         s.Customer.CustomerID == e.CustomerID &&
                         s.Product.ProductID == e.ProductID).SingleOrDefault();
                if (PurchaseInDataBase == null)
                {
                    context.Purchases.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}