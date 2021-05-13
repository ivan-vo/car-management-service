using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace managementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerManagementController : ControllerBase
    {
        private CarManagementService service;
        public ManagerManagementController(CarManagementService service)
        {
            this.service = service;
        }

        [HttpGet("/managers")]
        public ActionResult<IEnumerable<Manager>> GetManagers()
        {
            return Ok(service.GetManagers());
        }
        [HttpPost("/managers")]
        public ActionResult<IEnumerable<Manager>> CreateManager(Manager manager)
        {
            Manager newManager = service.CreateNewManager(manager);
            return Created($"/cars/{newManager.id}", newManager);
        }
    }
}