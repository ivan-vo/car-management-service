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
        public List<ManagerDealsCountDTO> GetManagersDeals()
        {
            return(
                from deal in _context.Set<Deal>()
                join manager in _context.Set<Manager>()
                    on deal.manager_.id equals manager.id
                    group deal by deal.manager_.id into g
                    select new ManagerDealsCountDTO(){managerId=g.Key, count=g.Count()}).ToList();
        }
        public TopManagerDTO GetTopManager()
        {
            List<ManagerDealsCountDTO> deals = GetManagersDeals();

            int maxDealsMangerId = 0;
            int count = 0;
                foreach (var manager in deals)
                {
                    if (manager.count >= count)
                    {
                        maxDealsMangerId = manager.managerId;
                        count = manager.count;
                    }
                }
            return (new TopManagerDTO {topManager = managerService.GetManager(maxDealsMangerId), countDeals = count});
        }
    }
}