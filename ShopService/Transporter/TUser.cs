using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Transporter
{
    [DataContract]
    public class TUser
    {
        [DataMember]
        public int userid { get; set; }

        [DataMember]
        public string username { get; set; }

        [DataMember]
        public string salt { get; set; }

        [DataMember]
        public string pass { get; set; }

        [DataMember]
        public bool role { get; set; }


        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string address { get; set; }

        [DataMember]
        public string phone { get; set; }

        [DataMember]
        public int timestamp { get; set; }


        public override string ToString()
        {
            return username.ToString();
        }
    }
}
