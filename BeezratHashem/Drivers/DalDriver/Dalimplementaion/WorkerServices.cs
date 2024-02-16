using DalDriver.DalApi;
using DalDriver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDriver.Dalimplementaion
{
    public class WorkerServices:IWorker
    {
        DriverContext drivercontext;
        public WorkerServices(DriverContext drivercontext)
        {
            this.drivercontext = drivercontext;
        }

        public Worker Add(Worker worker)
        {
            drivercontext.Workers.Add(worker);
            drivercontext.SaveChanges();
            return worker;
        }


        public List<Worker> GetAll()
        {
            IEnumerable<Worker>  workers= drivercontext.Workers;

            return workers.ToList();
        }
        public Worker Get(int id)
        {
            return drivercontext.Workers.FirstOrDefault(p => p.Id == id);
        }

        public Worker Update(Worker worker, int id)
        {
            drivercontext.Workers.FirstOrDefault(p => p.Id == id).Id = worker.Id;
            drivercontext.Workers.FirstOrDefault(p => p.Id == id).FirstName = worker.FirstName;
            drivercontext.Workers.FirstOrDefault(p => p.Id == id).LastName = worker.LastName;
            drivercontext.Workers.FirstOrDefault(p => p.Id == id).AddressId = worker.AddressId;
            drivercontext.Workers.FirstOrDefault(p => p.Id == id).TypeOfWorker = worker.TypeOfWorker;

            drivercontext.SaveChanges();
            return worker;
        }



        public int Delete(int id)
        {
            drivercontext.Workers.Remove(drivercontext.Workers.FirstOrDefault(p => p.Id == id));
            drivercontext.SaveChanges();
            return id;

        }


    }
}
