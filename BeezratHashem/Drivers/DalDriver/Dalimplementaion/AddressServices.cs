using DalDriver.DalApi;
using DalDriver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.Dalimplementaion
{
    public class AddressServices : IAddress
    {
        DriverContext drivercontext;
        public AddressServices(DriverContext drivercontext)
        {
            this.drivercontext = drivercontext; 
        }

        public Address Add(Address address)
        {
            drivercontext.Addresses.Add(address);
            drivercontext.SaveChanges();
            return address;
        }


        public List<Address>  GetAll()
        {
            IEnumerable<Address> addresses = drivercontext.Addresses;

            return addresses.ToList();
        }
        public Address Get(int id)
        {
            return drivercontext.Addresses.FirstOrDefault(p => p.Id == id);
        }

        public Address Update(Address address,int id)
        {
            drivercontext.Addresses.FirstOrDefault(p=>p.Id==id).Id=address.Id;
            drivercontext.Addresses.FirstOrDefault(p => p.Id == id).City = address.City;
            drivercontext.Addresses.FirstOrDefault(p => p.Id == id).Street = address.Street;
            drivercontext.Addresses.FirstOrDefault(p => p.Id == id).Building = address.Building;
            drivercontext.Addresses.FirstOrDefault(p => p.Id == id).AppartmentNum = address.AppartmentNum;

            drivercontext.SaveChanges ();
            return address;
        }

       

        public int Delete(int id)
        {
            drivercontext.Addresses.Remove(drivercontext.Addresses.FirstOrDefault(p=>p.Id==id));
            drivercontext.SaveChanges();
            return id;

        }

        
    }
}
