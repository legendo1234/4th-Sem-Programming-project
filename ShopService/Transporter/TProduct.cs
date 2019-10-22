using System.Runtime.Serialization;

namespace ShopService.Transporter
{
    [DataContract]
    public class TProduct
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int category { get; set; }
        [DataMember]
        public int stock { get; set; }
        [DataMember]
        public decimal price { get; set; }
        [DataMember]
        public int timestamp { get; set; }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
