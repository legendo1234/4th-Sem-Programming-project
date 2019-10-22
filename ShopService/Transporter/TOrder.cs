using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Transporter
{
    [DataContract]
    public class TOrder
    {
        [DataMember]
        public int orderid;
        [DataMember]
        public int userid;
        [DataMember]
        public string date;
        [DataMember]
        public bool isDelivered;
        [DataMember]
        public decimal price;
        [DataMember]
        public List<TOrderItem> items;
        public TOrder()
        {
            items = new List<TOrderItem>();
        }
    }
}
