using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<TransactionEntity> Transactions { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=SERVER-NAME;Database=InventoryDb;User Id=USER;Password=PASSWORD");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //Llamar el método de la clase padre

            modelBuilder.Entity<CategoryEntity>().HasData(
                    new CategoryEntity { CategoryId="CMS", CategoryName="Camisetas"},
                    new CategoryEntity { CategoryId = "CHQ", CategoryName = "Chaquetas" },
                    new CategoryEntity { CategoryId = "PNL", CategoryName = "Pantalonetas" },
                    new CategoryEntity { CategoryId = "TEN", CategoryName = "Tennis" }
                );
            modelBuilder.Entity<WareHouseEntity>().HasData(
                    new WareHouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central (Centro)" , WarehouseAddress ="Calle 1 # 2 - 3"},
                    new WareHouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Milán", WarehouseAddress = "Calle 1 # 2 - 3" },
                    new WareHouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Maltería", WarehouseAddress = "Calle 1 # 2 - 3" },
                    new WareHouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Estadio", WarehouseAddress = "Calle 1 # 2 - 3" }
                );
        }

    }
}
