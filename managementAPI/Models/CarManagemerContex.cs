using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class CarManagementContex : DbContext
{
    public DbSet<Deal> deal { get; set; }
    public DbSet<Car> cars { get; set; }
    public DbSet<Manager> managers { get; set; }

    public CarManagementContex(DbContextOptions<CarManagementContex> options) : base(options) { }
}

public class Deal
{
    public int id { get; set; }
    public DateTime? name { get; set; }
    public Car car_ { get; set; }
    public Manager manager_ { get; set; }
}

public class Car
{
    public int id { get; set; }
    public string brand { get; set; }
    public string model { get; set; }
    public string color { get; set; }
    public decimal price { get; set; }
}
public class Manager
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string surname { get; set; }
    public string last_name { get; set; }
    public DateTime date_recruitment { get; set; }
    public int sales { get; set; }
    public decimal salary { get; set; }
}