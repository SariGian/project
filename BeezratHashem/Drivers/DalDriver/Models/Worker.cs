using System;
using System.Collections.Generic;

namespace DalDriver.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int AddressId { get; set; }

    public string TypeOfWorker { get; set; }

    public virtual Address Address { get; set; }
}
