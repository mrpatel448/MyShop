﻿using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    
        // In the package manager console
        // View -> Other windows -> Package Manager Console
        //
        //Default Project select -> MyShop.DataAccess.SQL
        //Create folder named Migrations in MyShop.DataAccess.SQL
        //Run below code : 

        //Enable-Migrations
        //Add-Migration Initial
        //Update-Database

        // It will generate migration file in Migrations folder
        // it will create database in SQL
    }
}
