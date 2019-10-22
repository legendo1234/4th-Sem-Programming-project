using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Transporter;

namespace ShopService
{
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        bool Create(TProduct product);

        [OperationContract]
        TProduct Read(int id);

        [OperationContract]
        List<TProduct> ReadAll();

        [OperationContract]
        bool Update(TProduct product);

        [OperationContract]
        bool Delete(TProduct product);

        [OperationContract]
        bool Restock(TProduct product, int quantity);

    }
}
