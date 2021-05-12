using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace managementAPI
{
    public class CarManagementService
    {
        private CarManagementContex _context;

        public CarManagementService(CarManagementContex context)
        {
            this._context = context;
        }
        public Car CreateNewCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
            return car;
        }
        public Manager CreateNewManager(Manager manager)
        {
            _context.managers.Add(manager);
            _context.SaveChanges();
            return manager;
        }

        public List<Manager> GetManagers()
        {
            return _context.managers.ToList();
        }
        public List<Car> GetCars()
        {
            return _context.cars.ToList();
        }

        public Deal CreateNewDeal(DateTime date, int managerId, int carId)
        {
            Console.WriteLine(GetCar(carId));
            Car car = GetCar(carId);
            Manager manager = GetManager(managerId);
            Deal deal = new Deal() { date = date, car_ = car, manager_ = manager };
            _context.deals.Add(deal);
            _context.SaveChanges();
            return deal;
        }
        private Car GetCar(int id)
        {
            return _context.cars.Find(id);
        }
        private Manager GetManager(int id)
        {
            return _context.managers.Find(id);
        }
    }
}