﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TRShoppes.Models;

namespace TRShoppes.DAL
{
    public class ShopContext : DbContext
    {

        public ShopContext() : base("ShopContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Employee> Employees { get; set; }        
        public DbSet<Customer> Customers { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();           
        }
    }
}