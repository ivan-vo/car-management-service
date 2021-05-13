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
    public class CarManagementController : ControllerBase
    {
        private CarManagementService service;
        public CarManagementController(CarManagementService service)
        {
            this.service = service;
        }

        [HttpGet("/managers")]
        public ActionResult<IEnumerable<Manager>> GetManagers()
        {
            return Ok(service.GetManagers());
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

        [HttpPost("/managers")]
        public ActionResult<IEnumerable<Manager>> CreateManager(Manager manager)
        {
            Manager newManager = service.CreateNewManager(manager);
            return Created($"/cars/{newManager.id}", newManager);
        }
        [HttpPost("/deals")]
        public ActionResult<IEnumerable<Deal>> CreateDeal(DealDateManagerCatrDTO dto)
        {
            // Console.WriteLine(dto.carId);
            // Console.WriteLine(dto.date);
            // Console.WriteLine(dto.managerId);

            Deal newDeal = service.CreateNewDeal(dto.date, dto.managerId, dto.carId);
            return Created($"/cars/{newDeal.id}", newDeal);
        }
    }
}