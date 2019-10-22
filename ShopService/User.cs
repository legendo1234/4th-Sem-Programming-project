using ShopController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Transporter;

namespace ShopService
{
    public class User : IUser
    {
        UserController controller;
        public User()
        {
            controller = new UserController();
        }

        public TUser ModelToTransporter(ShopModel.User user)
        {
            TUser tuser = new TUser
            {
                userid = user.User_ID,
                username = user.Username,
                name = user.User_Information.Name,
                email = user.User_Information.Email,
                address = user.User_Information.Address,
                phone = user.User_Information.Phone
                
            };
            return tuser;
        }

        public ShopModel.User TransporterToModel(TUser tuser)
        {
            ShopModel.User user = new ShopModel.User
            {
                Username = tuser.username,
                Password = tuser.pass
            };
            return user;
        }

        public bool Login(string name, string pass)
        {
            return controller.Login(name, pass);
        }

        public bool AdminLogin(string name, string pass)
        {
            return controller.AdminLogin(name, pass);
        }
        

        public bool Create(TUser user)
        {
            return controller.Create(TransporterToModel(user));
        }

        public TUser Read(int id)
        {
            return ModelToTransporter(controller.Read(id));
        }

        public List<TUser> ReadAll()
        {
            List<TUser> tlist = new List<TUser>();
            List<ShopModel.User> list = new List<ShopModel.User>();
            list = controller.ReadAll();
            foreach (ShopModel.User u in list)
                tlist.Add(ModelToTransporter(u));
            return tlist;
        }

        public bool Update(TUser user)
        {
            return controller.Update(TransporterToModel(user));
        }

        public bool Delete(TUser user)
        {
            return controller.Delete(TransporterToModel(user));
        }
    }
}
