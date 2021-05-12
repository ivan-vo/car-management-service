using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagementAPI.Controllers
{
    [Route("api/CarManagement")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        private CarManagementService service;

        public ToDoItemController(CarManagementService service)
        {
            this.service = service;
        }

        [HttpGet("/1")]
        public ActionResult<IEnumerable<int>> GetAllToDoItems()
        {
            return Ok(service.GetONE());
        }
    }
}