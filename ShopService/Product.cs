using System.Collections.Generic;
using ShopController;
using ShopService.Transporter;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Product" in both code and config file together.
    public class Product : IProduct
    {
        ProductController controller;
        public Product()
        {
            controller = new ProductController();
        }

        public TProduct ModelToTransporter(ShopModel.Product product)
        {
            TProduct tproduct = new TProduct
            {
                id = product.Product_Id,
                name = product.Name,
                description = product.Description,
                category = product.Category_Id,
                stock = product.Stock,
                price = product.Price,
                timestamp = product.Timestamp
            };
            return tproduct;
        }

        public ShopModel.Product TransporterToModel(TProduct tproduct)
        {
            ShopModel.Product product = new ShopModel.Product
            {
                Product_Id = tproduct.id,
                Name = tproduct.name,
                Description = tproduct.description,
                Category_Id = tproduct.category,
                Stock = tproduct.stock,
                Price = tproduct.price,
                Timestamp = tproduct.timestamp
            };
            return product;
        }

        public bool Create(TProduct product)
        {
            return controller.Create(TransporterToModel(product));
        }

        public bool Delete(TProduct product)
        {
            return controller.Delete(TransporterToModel(product));
        }

        public TProduct Read(int id)
        {
            return ModelToTransporter(controller.Read(id));
        }
        
        public List<TProduct> ReadAll()
        {
            List<TProduct> tlist = new List<TProduct>();
            List<ShopModel.Product> list = new List<ShopModel.Product>();
            list = controller.ReadAll();
            foreach (ShopModel.Product p in list)
                tlist.Add(ModelToTransporter(p));
            return tlist;
        }

        public bool Update(TProduct product)
        {
            return controller.Update(TransporterToModel(product));
        }

        public bool Restock(TProduct product, int quantity)
        {
            return controller.Restock(TransporterToModel(product), quantity);
        }
    }
}
