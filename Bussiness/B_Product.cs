using Entities;
using System;
using System.Collections.Generic;
using DataAccess;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bussiness
{
    public class B_Product
    {
        //CRUD. Create, Read, Update, Delete

        public static List<ProductEntity> ProductList()
        {
            using(var db=new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity GetProductById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.FirstOrDefault
                    (p => p.ProductId == id);
            }
        }

        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Remove(oProduct);
            }
        }

    }
}
