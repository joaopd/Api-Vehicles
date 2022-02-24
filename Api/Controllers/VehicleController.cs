using Microsoft.AspNetCore.Mvc;
using AppServices.Vehicle;
using AppServices.Vehicle.Create.ViewModels;
using AppServices.Vehicle.Updates.ViewModels;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/vehicle")]
    public class VehicleController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Create(
            [FromServices] ICreateVehicle createVehicle,
            [FromBody] CreateVehicleViewModel createVehicleViewModel)
        {
            try
            {
                var result = await createVehicle
                    .Execute(createVehicleViewModel)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new ArgumentNullException("Not Found", e);
            }
        }

        [HttpPut("")]
        public async Task<IActionResult> Update(
        [FromServices] IUpdateVehicle updateVehicle,
        [FromBody] UpdateVehicleViewModel updateVehicleViewModel)
        {
            try
            {
                var result = await updateVehicle
                    .Execute(updateVehicleViewModel)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Not Found");
            }
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(
        [FromServices] IGetAllVehicle getAllVehicle)
        {
            try
            {
                var result = await getAllVehicle
                    .Execute()
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Not Found");
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(
        [FromServices] IGetByIdVehicle getByIdVehicle, Guid id)
        {
            try
            {
                var result = await getByIdVehicle
                    .Execute(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Not Found");
            }
        }
    }
}