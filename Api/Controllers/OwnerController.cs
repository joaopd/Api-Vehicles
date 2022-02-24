using Microsoft.AspNetCore.Mvc;
using Services.Owner;
using Services.Owner.Create.ViewModels;
using Services.Owner.GetAll.ViewModels;
using Services.Owner.Update.ViewModels;

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
            catch (Exception)
            {

                throw new ArgumentNullException("Not Found");
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(
        [FromServices] IUpdateOwner updateOwner,
        [FromBody] UpdateOwnerViewModel updateOwnerViewModel, Guid id)
        {
            try
            {
                updateOwnerViewModel.Id = id;

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