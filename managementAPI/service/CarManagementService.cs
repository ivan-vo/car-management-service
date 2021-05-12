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

        public CarManagementService ( CarManagementContex context) 
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

        public List<Manager> GetMagers()
        {
            return _context.managers.ToList();
        }
        public List<Car> GetCars()
        {
            return _context.cars.ToList();
        }

        public Deal CreateNewDeal(Deal deal, Manager manager, Car car)
        {
            deal.car_ = car;
            deal.manager_ = manager;
            _context.deals.Add(deal);
            _context.SaveChanges();
            return deal;
        }
    }
}