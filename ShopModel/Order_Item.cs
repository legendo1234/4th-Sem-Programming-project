namespace ShopModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Item
    {
        [Key]
        public int Item_Id { get; set; }

        public int Product_Id { get; set; }

        public int Order_Id { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
