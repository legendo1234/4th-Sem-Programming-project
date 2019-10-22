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
    public interface ICategory
    {
        [OperationContract]
        bool Create(TCategory t);

        [OperationContract]
        TCategory Read(int id);

        [OperationContract]
        List<TCategory> ReadAll();

        [OperationContract]
        bool Update(TCategory t);

        [OperationContract]
        bool Delete(TCategory t);
    }    
}
