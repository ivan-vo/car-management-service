using System;
using System.Collections.Generic;
using System.Linq;

namespace managementAPI
{
    public class CarManagementService
    {
        private ManagementContex _context;

        public CarManagementService(ManagementContex context)
        {
            this._context = context;
        }
        public Car CreateNewCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
            return car;
        }
        public List<Car> GetCars()
        {
            return _context.cars.ToList();
        }
        public Car GetCar(int id)
        {
            return _context.cars.Find(id);
        }
    }
}