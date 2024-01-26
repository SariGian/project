using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.DalApi
{
    public interface IRepo<T>
    {
        T GetAll();
        T Get(string id);
        T Add(T obj);
        T Update(T obj);


    }
}
