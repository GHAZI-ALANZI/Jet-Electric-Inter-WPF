﻿using Jet_Electric_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Jet_Electric_DataAccessLayer.AppDbContext
{
    public partial class JetDbContext : DbContext
    {
        public JetDbContext()

        {
            Products = Set<Product>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Retrieve connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["Jet_Electric_Inter.Properties.Settings.JetConnection"].ConnectionString;

            // Configure the connection
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<Inventory>(i => i.ID);
            modelBuilder.Entity<Panel_ProjectBT>()
            .HasOne(pp => pp.Panel)
            .WithMany(p => p.Panel_ProjectBT)
            .HasForeignKey(pp => pp.PanelID);

            // Configure default values for the Name property
            modelBuilder.Entity<Designation>().HasData(
                new Designation { ID = 1, Name = "Director" },
                new Designation { ID = 2, Name = "Manager" },
                new Designation { ID = 3, Name = "HR-Manager" },
                new Designation { ID = 4, Name = "Sales-Manager" },
                new Designation { ID = 5, Name = "Finance Manager" },
                new Designation { ID = 6, Name = "Receptionistr" },
                new Designation { ID = 7, Name = "IT-Support-Specialist" }
            );

            // Configure default values for the Name property
            modelBuilder.Entity<EmployeeStatus>().HasData(
                new EmployeeStatus { ID = 1, Name = "worker" },
                new EmployeeStatus { ID = 2, Name = "Employee" },
                new EmployeeStatus { ID = 3, Name = "Self-employed" }

            );


        }



        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        internal virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<PanelShellGradeProtection> PanelShellGradeProtections { get; set; }
        public virtual DbSet<SizeType> SizeTypes { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<PaType> PaTypes { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<Product_CustomerOrderBT> Product_CustomerOrderBT { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Product_PurchaseOrderBT> Product_PurchaseOrderBT { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Panel_ProjectBT> Panel_ProjectBT { get; set; }
        public virtual DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }




    }
}
