using Microsoft.AspNetCore.Mvc;

namespace FleetManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVehicle")]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            await Task.Delay(10);
            return Vehicles;
        }

        [HttpPost(Name = "CreateVehicle")]
        public async Task<IActionResult> Create(Vehicle vehicle)
        {
            await Task.Delay(10);
            Vehicles.Add(vehicle);
            return Ok(vehicle);
        }

        [HttpDelete(Name = "DeleteVehicle")]
        public async Task<IActionResult> Delete(int id)
        {
            await Task.Delay(10);
            var vehicle = Vehicles.FirstOrDefault(v => v.Id == id);

            if (vehicle == null) return NotFound();

            Vehicles.Remove(vehicle);
            return Ok();
        }

        [HttpPut(Name = "UpdateVehicle")]
        public async Task<IActionResult> Update(Vehicle vehicle)
        {
            await Task.Delay(10);
            var vehicleFound = Vehicles.FirstOrDefault(v => v.Id == vehicle.Id);

            if (vehicleFound == null) return NotFound();

            vehicleFound.Plate = vehicle.Plate;
            vehicleFound.EngineNumber = vehicle.EngineNumber;
            vehicleFound.Brand = vehicle.Brand; 
            vehicleFound.Model = vehicle.Model;
            vehicleFound.Color = vehicle.Color;

            return Ok(vehicleFound);
        }
    }
}
