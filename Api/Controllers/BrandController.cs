using Microsoft.AspNetCore.Mvc;
using Services.Brand.Create;
using Services.Brand.Create.ViewModels;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class BrandController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Create(
            [FromServices] ICreateBrand createBrand,
            [FromBody] CreateBrandViewModel createBrandViewModel)
        {
            try
            {
                var result = await createBrand.Execute(createBrandViewModel).ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Objeto Vazio");
            }

        }
    }
}