namespace ShopModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Order_Item = new HashSet<Order_Item>();
        }

        [Key]
        public int Order_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Date { get; set; }

        public bool IsDelivered { get; set; }

        public decimal Price { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Item> Order_Item { get; set; }

        public int Timestamp;
    }
}
