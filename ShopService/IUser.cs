using System;
using System.Collections.Generic;
using System.ServiceModel;
using ShopService.Transporter;

namespace ShopService
{
    [ServiceContract]
    public interface IUser
    {

        [OperationContract]
        bool Login(string name, string pass);

        [OperationContract]
        bool AdminLogin(string name, string pass);

        [OperationContract]
        bool Create(TUser user);

        [OperationContract]
        TUser Read(int id);

        [OperationContract]
        List<TUser> ReadAll();
        
        [OperationContract]
        bool Update(TUser user);

        [OperationContract]
        bool Delete(TUser user);
    }
}
