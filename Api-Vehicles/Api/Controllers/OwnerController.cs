using AppServices.Owner;
using AppServices.Owner.Create.ViewModels;
using AppServices.Owner.Update.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/owner")]
    public class OwnerController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Create(
            [FromServices] ICreateOwner createOwner,
            [FromBody] CreateOwnerViewModel createOwnerViewModel)
        {
            try
            {
                var result = await createOwner
                    .Execute(createOwnerViewModel)
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
        [FromServices] IUpdateOwner updateOwner,
        [FromBody] UpdateOwnerViewModel updateOwnerViewModel)
        {
            try
            {
                var result = await updateOwner
                    .Execute(updateOwnerViewModel)
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
        [FromServices] IGetAllOwner getAllOwner)
        {
            try
            {
                var result = await getAllOwner
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
        [FromServices] IGetByIdOwner getByIdOwner, Guid id)
        {
            try
            {
                var result = await getByIdOwner
                    .Execute(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Not Found");
            }
        }

        [HttpGet("Activated")]
        public async Task<IActionResult> GetActiveted(
        [FromServices] IGetActivedOwner getActivedOwner)
        {
            try
            {
                var result = await getActivedOwner
                    .Execute()
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