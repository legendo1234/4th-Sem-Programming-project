using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ShopServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start_Services();
        }

        public void Start_Services()
        {
            ServiceHost user = new ServiceHost(typeof(ShopService.User));
            ServiceHost category = new ServiceHost(typeof(ShopService.Category));
            ServiceHost product = new ServiceHost(typeof(ShopService.Product));
            ServiceHost order = new ServiceHost(typeof(ShopService.Order));
            try
            {
                user.Open();
                category.Open();
                product.Open();
                order.Open();
                Console.WriteLine("All services are ready to be consumed!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
