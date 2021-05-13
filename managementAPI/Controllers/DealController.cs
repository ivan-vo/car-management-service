using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace managementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealManagementController : ControllerBase
    {
        private DealManagementService service;
        public DealManagementController(DealManagementService service)
        {
            this.service = service;
        }

        [HttpPost("/deals")]
        public ActionResult<IEnumerable<Deal>> CreateDeal(DealDateManagerCatrDTO dto)
        {
            Deal newDeal = service.CreateNewDeal(dto.date, dto.managerId, dto.carId);
            return Created($"/cars/{newDeal.id}", newDeal);
        }
    }
}