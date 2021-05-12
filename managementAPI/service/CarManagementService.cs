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

        public int GetONE()
        {
            return 1;
        }

        public void CreateNewCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }
    }
}