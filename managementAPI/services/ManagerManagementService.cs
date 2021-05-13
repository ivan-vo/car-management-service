using System;
using System.Collections.Generic;
using System.Linq;

namespace managementAPI
{
    public class ManagerManagementService
    {
        private ManagementContex _context;

        public ManagerManagementService(ManagementContex context)
        {
            this._context = context;
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
        public Manager GetManager(int id)
        {
            return _context.managers.Find(id);
        }
    }
}