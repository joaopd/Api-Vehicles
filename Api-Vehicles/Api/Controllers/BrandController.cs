using AppServices.Brand;
using AppServices.Brand.Create.ViewModels;
using AppServices.Brand.Update.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/brand")]

    public class BrandController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Create(
            [FromServices] ICreateBrand createBrand,
            [FromBody] CreateBrandViewModel createBrandViewModel)
        {
            try
            {
                var result = await createBrand
                    .Execute(createBrandViewModel)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }

        [HttpPut("")]
        public async Task<IActionResult> Update(
        [FromServices] IUpdateBrand updateBrand,
        [FromBody] UpdateBrandViewModel updateBrandViewModel)
        {
            try
            {
                var result = await updateBrand
                    .Execute(updateBrandViewModel)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(
        [FromServices] IGetAllBrand getAllBrand)
        {
            try
            {
                var result = await getAllBrand
                    .Execute()
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new ArgumentNullException("Not Found", e);
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(
        [FromServices] IGetByIdBrand getByIdBrand, Guid id)
        {
            try
            {
                var result = await getByIdBrand
                    .Execute(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new ArgumentNullException("Not Found", e);
            }
        }

        [HttpGet("Activated")]
        public async Task<IActionResult> GetActiveted(
        [FromServices] IGetActivedBrand getActivedBrand)
        {
            try
            {
                var result = await getActivedBrand
                    .Execute()
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {

                throw new ArgumentNullException("Not Found", e);
            }
        }
    }
}