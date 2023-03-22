namespace BAJK.EAutoSerwis.Car.WebApplication.Controllers
{
    using BAJK.EAutoSerwis.solution.xLib;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase, ICarLot
    {
        private readonly ILogger<CarController> logger;
        private readonly CarLot carLot;

        public CarController(ILogger<CarController> logger)
        {
            this.logger = logger;
            carLot = new CarLot();
        }

        [HttpGet]
        [Route("GetExpiredCheckUp")]
        public Car[] FindExpiredCheckUp()
        {
            return carLot.FindExpiredCheckUp();
        }
        [HttpGet]
        [Route("GetSameBrands")]
        public Car[] FindAllTheSameBrands(string name)
        {
            return carLot.FindAllTheSameBrands(name);
        }
        [HttpPost]
        [Route("AddNewCar")]
        public void AddNewCar(CarDto newCar)
        {
            carLot.AddNewCar(newCar);
        }
    }
}
