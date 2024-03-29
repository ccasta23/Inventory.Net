﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20200603215001_ChangeColumnType")]
    partial class ChangeColumnType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "CMS",
                            CategoryName = "Camisetas"
                        },
                        new
                        {
                            CategoryId = "CHQ",
                            CategoryName = "Chaquetas"
                        },
                        new
                        {
                            CategoryId = "PNL",
                            CategoryName = "Pantalonetas"
                        },
                        new
                        {
                            CategoryId = "TEN",
                            CategoryName = "Tennis"
                        });
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WareHouseId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WareHouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.TransactionEntity", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("StorageId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Entities.WareHouseEntity", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WarehouseAddress")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("WarehouseId");

                    b.ToTable("WareHouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = "25a86018-ec20-4460-a688-576ac24a138d",
                            WarehouseAddress = "Calle 1 # 2 - 3",
                            WarehouseName = "Bodega Central (Centro)"
                        },
                        new
                        {
                            WarehouseId = "24a1fb3d-dbba-46d7-ba8e-b3ebfe825e2e",
                            WarehouseAddress = "Calle 1 # 2 - 3",
                            WarehouseName = "Bodega Milán"
                        },
                        new
                        {
                            WarehouseId = "8f6227c7-e90c-4a70-ba52-b1116d3718b7",
                            WarehouseAddress = "Calle 1 # 2 - 3",
                            WarehouseName = "Bodega Maltería"
                        },
                        new
                        {
                            WarehouseId = "2bf1bbc0-b1a4-4dcd-bb54-d4b961d49ae8",
                            WarehouseAddress = "Calle 1 # 2 - 3",
                            WarehouseName = "Bodega Estadio"
                        });
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("Entities.WareHouseEntity", "WareHouse")
                        .WithMany("Storages")
                        .HasForeignKey("WareHouseId");
                });

            modelBuilder.Entity("Entities.TransactionEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("Transactions")
                        .HasForeignKey("StorageId");
                });
#pragma warning restore 612, 618
        }
    }
}
