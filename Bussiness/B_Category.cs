using Entities;
using System;
using System.Collections.Generic;
using DataAccess;
using System.Text;
using System.Linq;

namespace Bussiness
{
    public class B_Category
    {
        //CRUD. Create, Read, Update, Delete

        public static List<CategoryEntity> CategoryList()
        {
            using(var db=new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity GetCategoryById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.FirstOrDefault
                    (c => c.CategoryId == id);
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

        public static void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }

    }
}
