using System;
using System.Collections.Generic;

namespace DalDriver.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public int Building { get; set; }

    public int? AppartmentNum { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
