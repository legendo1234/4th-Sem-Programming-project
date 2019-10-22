using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopModel;

namespace ShopController
{
    public class UserController : IController<User>
    {
        ShopModel.ShopModel db;
        User user;
        List<User> users;

        public UserController()
        {
            db = new ShopModel.ShopModel();
        }


        //Generates a salt of the desired size, which for now is 5
        public string SaltGenerator(int size)
        {
            string salt = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            for (int i = 0; i < size; i++)
                salt += chars[random.Next(chars.Length)];
            return salt;
        }
        //Hashes the input using SHA256
        public string Hasher(string input)
        {
            StringBuilder hash = new StringBuilder();
            System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
            byte[] crypted = sha.ComputeHash(Encoding.UTF8.GetBytes(input), 0, Encoding.UTF8.GetByteCount(input));
            foreach (byte chunk in crypted)
                hash.Append(chunk.ToString("x2"));
            return hash.ToString();
        }
        

        //Normal login
        public bool Login(string username, string password)
        {
            user = new User();
            user = db.Users.SingleOrDefault(x => x.Username == username);
            bool access = String.Equals(user.Password, Hasher(password + user.Salt), StringComparison.Ordinal);
            return access;
        }
        //Login that checks for administrator privileges
        public bool AdminLogin(string username, string password)
        {
            user = new User();
            user = db.Users.SingleOrDefault(x => x.Username == username);
            bool access = String.Equals(user.Password, Hasher(password + user.Salt), StringComparison.Ordinal) && user.Role == true;
            return access;
        }


        public bool Create(User t)
        {
            if (t != null && db.Users.SingleOrDefault(x => x.Username == t.Username)==null)
            {
                t.Salt = SaltGenerator(5);
                t.Password = Hasher(t.Password + t.Salt);
                t.Role = false;
                db.Users.Add(t);
                User_Information u = new User_Information();
                u.User_Id = t.User_ID;
                db.User_Information.Add(u);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public User Read(int id)
        {
            return db.Users.SingleOrDefault(x => x.User_ID == id);
        }

        public List<User> ReadAll()
        {
            return db.Users.ToList<User>();
        }

        public bool Update(User t)
        {
            throw new NotImplementedException("Will implement soon I swear");
            //use t.User_Information, call that
            //and modify it here maybe then
            //save the changes to db
        }

        public bool Delete(User t)
        {
            t = db.Users.SingleOrDefault(x => x.User_ID == t.User_ID);
            if (t != null)
            {
                if(t.User_Information != null)
                    db.User_Information.Remove(t.User_Information);
                db.Users.Remove(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public int GetTimestamp(int id)
        {
            throw new NotImplementedException("Oops");
            //will be used at updating user information
            //already in db
        }
    }
}
