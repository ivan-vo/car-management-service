using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using managementAPI.Models;

namespace managementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarManagementService service;
        public CarController(CarManagementService service)
        {
            this.service = service;
        }
        [HttpPost("/cars")]
        public void CreateCar(Car car)
        {
            service.CreateNewCar(car);
        }

    }
}