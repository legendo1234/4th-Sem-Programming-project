using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Transporter;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrder" in both code and config file together.
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        bool Create(TOrder order);

        [OperationContract]
        TOrder Read(int id);

        [OperationContract]
        List<TOrder> ReadAll ();

        [OperationContract]
        bool Update(TOrder order);

        [OperationContract]
        bool Delete(TOrder order);

    }
}
