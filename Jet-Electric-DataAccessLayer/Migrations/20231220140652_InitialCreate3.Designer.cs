﻿// <auto-generated />
using System;
using Jet_Electric_DataAccessLayer.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jet_Electric_DataAccessLayer.Migrations
{
    [DbContext(typeof(JetDbContext))]
    [Migration("20240510140652_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Certification", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.CustomerOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("OrderStatusID");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Designation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Designations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Director"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Manager"
                        },
                        new
                        {
                            ID = 3,
                            Name = "HR-Manager"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Sales-Manager"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Finance Manager"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Receptionistr"
                        },
                        new
                        {
                            ID = 7,
                            Name = "IT-Support-Specialist"
                        });
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DesignationID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeStatusID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DesignationID");

                    b.HasIndex("EmployeeStatusID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.EmployeeStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EmployeeStatus");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "worker"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Employee"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Self-employed"
                        });
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("StockLevel")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Vienna"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Berlin "
                        },
                        new
                        {
                            ID = 3,
                            Name = "Roma"
                        });
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Login", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Make", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.OrderStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PaType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PaTypes");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PanelShellGradeProtection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DescriptionLiquids")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionSolids")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PanelShellGradeProtections");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Panel_ProjectBT", b =>
                {
                    b.Property<int>("Panel_ProjectBTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Panel_ProjectBTId"));

                    b.Property<int>("PanelID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Panel_ProjectBTId");

                    b.HasIndex("PanelID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Panel_ProjectBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("MakeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MakeID");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product_CustomerOrderBT", b =>
                {
                    b.Property<int>("Product_CustomerOrderBTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_CustomerOrderBTId"));

                    b.Property<int>("CustomerOrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Product_CustomerOrderBTId");

                    b.HasIndex("CustomerOrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("Product_CustomerOrderBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product_PurchaseOrderBT", b =>
                {
                    b.Property<int>("Product_PurchaseOrderBTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_PurchaseOrderBTId"));

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseOrderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Product_PurchaseOrderBTId");

                    b.HasIndex("ProductID");

                    b.HasIndex("PurchaseOrderID");

                    b.ToTable("Product_PurchaseOrderBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerOrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerOrderID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PODate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("OrderStatusID");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.SizeType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SizeTypes");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Type", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Panel", b =>
                {
                    b.HasBaseType("Jet_Electric_DataAccessLayer.Models.Product");

                    b.Property<int>("CertificationID")
                        .HasColumnType("int");

                    b.Property<int>("PanelShellGradeProtectionID")
                        .HasColumnType("int");

                    b.Property<int>("PanelShellGradeProtectionIPNumber")
                        .HasColumnType("int");

                    b.Property<int>("SizeTypeID")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasIndex("CertificationID");

                    b.HasIndex("PanelShellGradeProtectionID");

                    b.HasIndex("SizeTypeID");

                    b.HasIndex("TypeID");

                    b.HasDiscriminator().HasValue("Panel");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Part", b =>
                {
                    b.HasBaseType("Jet_Electric_DataAccessLayer.Models.Product");

                    b.Property<int>("PaTypeID")
                        .HasColumnType("int");

                    b.HasIndex("PaTypeID");

                    b.HasDiscriminator().HasValue("Part");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.CustomerOrder", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Contact", "Contact")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Employee", "Employee")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.OrderStatus", "OrderStatus")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("OrderStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Employee");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Employee", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Designation", "Designation")
                        .WithMany("Employees")
                        .HasForeignKey("DesignationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.EmployeeStatus", "EmployeeStatus")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designation");

                    b.Navigation("EmployeeStatus");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Inventory", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Product", "Product")
                        .WithOne("Inventory")
                        .HasForeignKey("Jet_Electric_DataAccessLayer.Models.Inventory", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Location", "Location")
                        .WithMany("Inventories")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Panel_ProjectBT", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Panel", "Panel")
                        .WithMany("Panel_ProjectBT")
                        .HasForeignKey("PanelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Project", "Project")
                        .WithMany("Panel_ProjectBT")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Panel");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Make", "Make")
                        .WithMany("Products")
                        .HasForeignKey("MakeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Make");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product_CustomerOrderBT", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.CustomerOrder", "CustomerOrder")
                        .WithMany("Product_CustomerOrderBT")
                        .HasForeignKey("CustomerOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Product", "Product")
                        .WithMany("Product_CustomerOrderBT")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product_PurchaseOrderBT", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Product", "Product")
                        .WithMany("Product_PurchaseOrderBT")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("Product_PurchaseOrderBT")
                        .HasForeignKey("PurchaseOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Project", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.CustomerOrder", "CustomerOrder")
                        .WithMany("Projects")
                        .HasForeignKey("CustomerOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerOrder");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PurchaseOrder", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Contact", "Contact")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Employee", "Employee")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.OrderStatus", "OrderStatus")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("OrderStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Employee");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Panel", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Certification", "Certification")
                        .WithMany("Panels")
                        .HasForeignKey("CertificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.PanelShellGradeProtection", "PanelShellGradeProtection")
                        .WithMany("Panels")
                        .HasForeignKey("PanelShellGradeProtectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.SizeType", "SizeType")
                        .WithMany("Panels")
                        .HasForeignKey("SizeTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jet_Electric_DataAccessLayer.Models.Type", "Type")
                        .WithMany("Panels")
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certification");

                    b.Navigation("PanelShellGradeProtection");

                    b.Navigation("SizeType");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Part", b =>
                {
                    b.HasOne("Jet_Electric_DataAccessLayer.Models.PaType", "PaType")
                        .WithMany("Parts")
                        .HasForeignKey("PaTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaType");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Certification", b =>
                {
                    b.Navigation("Panels");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Contact", b =>
                {
                    b.Navigation("CustomerOrders");

                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.CustomerOrder", b =>
                {
                    b.Navigation("Product_CustomerOrderBT");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Designation", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Employee", b =>
                {
                    b.Navigation("CustomerOrders");

                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.EmployeeStatus", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Location", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Make", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.OrderStatus", b =>
                {
                    b.Navigation("CustomerOrders");

                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PaType", b =>
                {
                    b.Navigation("Parts");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PanelShellGradeProtection", b =>
                {
                    b.Navigation("Panels");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Product", b =>
                {
                    b.Navigation("Inventory")
                        .IsRequired();

                    b.Navigation("Product_CustomerOrderBT");

                    b.Navigation("Product_PurchaseOrderBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Project", b =>
                {
                    b.Navigation("Panel_ProjectBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.PurchaseOrder", b =>
                {
                    b.Navigation("Product_PurchaseOrderBT");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.SizeType", b =>
                {
                    b.Navigation("Panels");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Type", b =>
                {
                    b.Navigation("Panels");
                });

            modelBuilder.Entity("Jet_Electric_DataAccessLayer.Models.Panel", b =>
                {
                    b.Navigation("Panel_ProjectBT");
                });
#pragma warning restore 612, 618
        }
    }
}
