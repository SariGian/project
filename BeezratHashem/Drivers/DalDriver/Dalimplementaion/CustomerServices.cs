using DalDriver.DalApi;
using DalDriver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.Dalimplementaion
{
    public class CustomerServices : ICustomer
    {
        DriverContext drivercontext;
        public CustomerServices(DriverContext drivercontext)
        {
            this.drivercontext = drivercontext;
        }

        public Customer Add(Customer customer)
        {
            drivercontext.Customers.Add(customer);
            drivercontext.SaveChanges();
            return customer;
        }


        public List<Customer> GetAll()
        {
            IEnumerable<Customer> customers = drivercontext.Customers;

            return customers.ToList();
        }
        public Customer Get(int id)
        {
            return drivercontext.Customers.FirstOrDefault(p => p.Id == id);
        }

        public Customer Update(Customer customer, int id)
        {
            drivercontext.Customers.FirstOrDefault(p => p.Id == id).Id = customer.Id;
            drivercontext.Customers.FirstOrDefault(p => p.Id == id).FirstName = customer.FirstName;
            drivercontext.Customers.FirstOrDefault(p => p.Id == id).LastName = customer.LastName;
            drivercontext.Customers.FirstOrDefault(p => p.Id == id).AddressId = customer.AddressId;

            drivercontext.SaveChanges();
            return customer;
        }



        public int Delete(int id)
        {
            drivercontext.Customers.Remove(drivercontext.Customers.FirstOrDefault(p => p.Id == id));
            drivercontext.SaveChanges();
            return id;

        }
    }
}
