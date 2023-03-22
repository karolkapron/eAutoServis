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
    public class MechanicController : ControllerBase, IMechanicLot
    {
        private readonly ILogger<MechanicController> logger;
        private readonly IMechanicLot mechanicLot;
        public MechanicController(ILogger<MechanicController> logger)
        {
            this.logger = logger;
            mechanicLot = new MechanicLot();
        }
        [HttpGet]
        [Route("GetAllMechanics")]
        public Mechanic[] GetAllMechanics()
        {
            return mechanicLot.GetAllMechanics();
        }
        [HttpPost]
        [Route("AddNewMechanic")]
        public void AddNewMechanic(MechanicDto newMechanic)
        {
            mechanicLot.AddNewMechanic(newMechanic);
        }
    }
}
