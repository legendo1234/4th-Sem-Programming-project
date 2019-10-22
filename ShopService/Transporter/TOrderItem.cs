using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Transporter
{
    [DataContract]
    public class TOrderItem
    {
        [DataMember]
        public int itemid;
        [DataMember]
        public int orderid;
        [DataMember]
        public int productid;
        [DataMember]
        public int quantity;
        [DataMember]
        public decimal price;
    }
}
