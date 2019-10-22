using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel;

namespace ShopController
{
    public class ProductController:IController<Product>
    {
        ShopModel.ShopModel db;
        Product product;
        List<Product> products;
        public ProductController()
        {
            db = new ShopModel.ShopModel();
        }

        public bool Create(Product t)
        {
            if (t != null)
            {
                db.Products.Add(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Product Read(int id)
        {
            return db.Products.SingleOrDefault(x => x.Product_Id == id);
        }

        public List<Product> ReadAll()
        {
            return db.Products.ToList<Product>();
        }

        public bool Update(Product t)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Product_Id))
                {
                    product = db.Products.SingleOrDefault(x => x.Product_Id == t.Product_Id);
                    product.Name = t.Name;
                    product.Description = t.Description;
                    product.Category_Id = t.Category_Id;
                    product.Stock = t.Stock;
                    product.Price = t.Price;
                    product.Timestamp++;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool Delete(Product t)
        {
            t = db.Products.SingleOrDefault(x => x.Product_Id == t.Product_Id);
            if (t != null)
            {
                db.Products.Remove(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Restock(Product t, int quantity)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Product_Id))
                {
                    product = db.Products.SingleOrDefault(x => x.Product_Id == t.Product_Id);
                    product.Stock += quantity;
                    product.Timestamp++;
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
            product = db.Products.SingleOrDefault(x => x.Product_Id == id);
            if (product != null)
                return product.Timestamp;
            else
                return -1;
        }

    }
}
