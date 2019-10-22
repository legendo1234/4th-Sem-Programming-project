using System;
using System.Collections.Generic;
using System.Linq;
using ShopModel;

namespace ShopController
{
    public class CategoryController : IController<Category>
    {
        ShopModel.ShopModel db;
        Category category;
        List<Category> categories;

        public CategoryController()
        {
            db = new ShopModel.ShopModel();
            category = new Category();
            categories = new List<Category>();
        }

        public bool Create(Category t)
        {
            if (t != null)
            {
                db.Categories.Add(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Category Read(int id)
        {
            return db.Categories.SingleOrDefault(x => x.Category_Id == id);
        }

        public List<Category> ReadAll()
        {
            return db.Categories.ToList<Category>();
        }
        public bool Update(Category t)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Category_Id))
                {
                    category = db.Categories.SingleOrDefault(x => x.Category_Id == t.Category_Id);
                    category.Name = t.Name;
                    category.Timestamp++;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool Delete(Category t)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Category_Id))
                {
                    t = db.Categories.SingleOrDefault(x => x.Category_Id == t.Category_Id);
                    db.Categories.Remove(t);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public int GetTimestamp(int id)
        {
            category = db.Categories.SingleOrDefault(x => x.Category_Id == id);
            if (category != null)
                return category.Timestamp;
            else
                return -1;
        }
    }
}
