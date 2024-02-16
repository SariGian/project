//using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.DalApi
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Add(T obj);
        T Update(T obj,int id);
        int Delete(int id);

    }
}
