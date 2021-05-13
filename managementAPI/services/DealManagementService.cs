using System;
using System.Collections.Generic;
using System.Linq;

namespace managementAPI
{
    public class DealManagementService
    {
        private ManagementContex _context;
        private CarManagementService carService;
        private ManagerManagementService managerService;

        public DealManagementService(ManagementContex context, CarManagementService carService, ManagerManagementService managerService)
        {
            this._context = context;
            this.carService = carService;
            this.managerService = managerService;
        }

        public Deal CreateNewDeal(DateTime date, int managerId, int carId)
        {
            Car car = carService.GetCar(carId);
            Manager manager = managerService.GetManager(managerId);
            Deal deal = new Deal() { date = date, car_ = car, manager_ = manager };
            _context.deals.Add(deal);
            _context.SaveChanges();
            return deal;
        }
    }
}