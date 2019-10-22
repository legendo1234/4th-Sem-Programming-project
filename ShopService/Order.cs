using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopController;
using ShopService.Transporter;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Order" in both code and config file together.
    public class Order : IOrder
    {
        public OrderController controller;
        public Order()
        {
            controller = new OrderController();
        }

        ShopModel.Order TransporterToModel(TOrder torder)
        {
            ShopModel.Order order = new ShopModel.Order
            {
                Order_Id = torder.orderid,
                User_Id = torder.userid,
                Date = torder.date,
                IsDelivered = false,
                Price = torder.price
            };
            foreach(TOrderItem titem in torder.items)
            {
                ShopModel.Order_Item item = new ShopModel.Order_Item
                {
                    Product_Id = titem.productid,
                    Order_Id = titem.orderid,
                    Quantity = titem.quantity,
                    Price = titem.price
                };
                order.Order_Item.Add(item);
            }
            return order;
        }

        TOrder ModelToTransporter(ShopModel.Order order)
        {
            TOrder torder = new TOrder{
                orderid = order.Order_Id,
                date = order.Date,
                price = order.Price,
                userid = order.User_Id,
                isDelivered = order.IsDelivered
            };
            foreach(ShopModel.Order_Item item in order.Order_Item)
            {
                TOrderItem titem = new TOrderItem
                {
                    itemid = item.Item_Id,
                    productid = item.Product_Id,
                    quantity = item.Quantity,
                    price = item.Price
                };
                torder.items.Add(titem);
            }
            return torder;
        }

        public bool Create(TOrder order)
        {
            return controller.Create(TransporterToModel(order));
        }

        public TOrder Read(int id)
        {
            return ModelToTransporter(controller.Read(id));
        }

        public List<TOrder> ReadAll()
        {
            List<TOrder> tlist = new List<TOrder>();
            List<ShopModel.Order> list = new List<ShopModel.Order>();
            list = controller.ReadAll();
            foreach (ShopModel.Order order in list)
                tlist.Add(ModelToTransporter(order));
            return tlist;
        }

        public bool Update(TOrder order)
        {
            return controller.Update(TransporterToModel(order));
        }

        public bool Delete(TOrder order)
        {
            return controller.Delete(TransporterToModel(order));
        }
    }
}
