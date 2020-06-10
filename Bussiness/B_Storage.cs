using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Bussiness
{
    public class B_Storage
    {
        //CRUD. Create, Read, Update, Delete

        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageListInWarehouse(string WarehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(s => s.Product) //Incluyendo la información de los productos
                    .Include(s => s.WareHouse) //Incluyendo la información de las bodegas
                    .Where(s => s.WareHouseId == WarehouseId)
                    .ToList();
            }
        }

        public static StorageEntity GetStorageById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.FirstOrDefault
                    (c => c.StorageId == id);
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(string StorageId)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages.ToList()
                    .Where(s => s.StorageId == StorageId);

                return product.Any();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        public static void DeleteStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Remove(oStorage);
                db.SaveChanges();
            }
        }
    }
}
