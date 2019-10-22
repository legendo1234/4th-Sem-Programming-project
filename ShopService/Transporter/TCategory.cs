using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Transporter
{
    [DataContract]
    public class TCategory
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int timestamp { get; set; }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
