using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Warehouse
    {
        //CRUD. Create, Read, Update, Delete

        public static List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventoryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public static WareHouseEntity GetWareHouseById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.WareHouses.FirstOrDefault
                    (c => c.WarehouseId == id);
            }
        }

        public static void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                oWareHouse.WarehouseId = Guid.NewGuid().ToString();
                db.WareHouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.WareHouses.Update(oWareHouse);
                db.SaveChanges();
            }
        }

        public static void DeleteWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.WareHouses.Remove(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
