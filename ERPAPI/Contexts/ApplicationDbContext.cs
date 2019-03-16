﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPAPI.Models;

namespace ERP.Contexts
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomersOfCustomer> CustomersOfCustomer { get; set; }
        public DbSet<CustomerType> CustomerType { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<VendorType> VendorType { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<SalesOrderLine> SalesOrderLine { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<ShipmentType> ShipmentType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<Estados> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var Customers = new List<Customer>()
            //{
            //     new Customer(){CustomerId=1,CustomerName="CAFE TOSTANO"},
            //     new Customer(){CustomerId=2,CustomerName="CAFE INDIO"},
            //};

            //modelBuilder.Entity<Customer>().HasData(Customers);

            base.OnModelCreating(modelBuilder);
        }
    }
}
