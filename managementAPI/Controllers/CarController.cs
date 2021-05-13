using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace managementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarManagementController : ControllerBase
    {
        private CarManagementService service;
        public CarManagementController(CarManagementService service)
        {
            this.service = service;
        }
        [HttpGet("/cars")]
        public ActionResult<IEnumerable<Manager>> GetCars()
        {
            return Ok(service.GetCars());
        }

        [HttpPost("/cars")]
        public ActionResult<IEnumerable<Car>> CreateCar(Car car)
        {
            Car newCar = service.CreateNewCar(car);
            return Created($"/cars/{newCar.id}", newCar);
        }
    }
}