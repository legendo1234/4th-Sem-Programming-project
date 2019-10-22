using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopController
{
    public interface IController<T>
    {
        bool Create(T t);
        T Read(int id);
        List<T> ReadAll();
        bool Update(T t);
        bool Delete(T t);
        int GetTimestamp(int id);
        string ToString();
    }
}
