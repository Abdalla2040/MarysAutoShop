﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marys_Auto.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarysAutoShopDBEntities : DbContext
    {
        public MarysAutoShopDBEntities()
            : base("name=MarysAutoShopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer_Vehicles> Customer_Vehicles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Estimate> Estimates { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Work_Assessment> Work_Assessment { get; set; }
        public virtual DbSet<Work_Order> Work_Order { get; set; }
    }
}
