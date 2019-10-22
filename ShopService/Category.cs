using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopModel;
using ShopController;
using ShopService.Transporter;

namespace ShopService
{
    public class Category : ICategory
    {
        CategoryController controller;
        public Category()
        {
            controller = new CategoryController();
        }

        public TCategory ModelToTransporter(ShopModel.Category t)
        {
            TCategory category = new TCategory
            {
                id = t.Category_Id,
                name = t.Name,
                timestamp = t.Timestamp
            };
            return category;
        }

        public ShopModel.Category TransporterToModel(TCategory t)
        {
            ShopModel.Category category = new ShopModel.Category
            {
                Category_Id = t.id,
                Name = t.name,
                Timestamp = t.timestamp
            };
            return category;
        }

        public bool Create(TCategory t)
        {
            return controller.Create(TransporterToModel(t));
        }
        public TCategory Read(int id)
        {
            return ModelToTransporter(controller.Read(id));
        }

        public List<TCategory> ReadAll()
        {
            List<TCategory> tlist = new List<TCategory>();
            List<ShopModel.Category> list = new List<ShopModel.Category>();
            list = controller.ReadAll();
            foreach (ShopModel.Category cat in list)
                tlist.Add(ModelToTransporter(cat));
            return tlist;
        }
        public bool Update(TCategory t)
        {
            return controller.Update(TransporterToModel(t));
        }

        public bool Delete(TCategory t)
        {
            return controller.Delete(TransporterToModel(t));
        }
    }
}
