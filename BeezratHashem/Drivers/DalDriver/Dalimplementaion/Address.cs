using DalDriver.DalApi;
using DalDriver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.Dalimplementaion
{
    public class Address : IAddress
    {
        DriverContext address;
        public Address(DriverContext address)
        {
            this.address = address; 
        }

        public Address Add(Address obj)
        {
            throw new NotImplementedException();
        }

        public Address Get(string id)
        {
            throw new NotImplementedException();
        }

        public Address GetAll()
        {
            throw new NotImplementedException();
        }

        public Address Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}
