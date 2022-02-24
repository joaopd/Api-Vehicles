using Microsoft.AspNetCore.Mvc;
using Services.Apis.Cep.GetCep;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class ApiBrasilController : ControllerBase
    {
        [HttpGet("postal-code")]
        public async Task<IActionResult> GetPostalCode(
            [FromServices] IApiBrasilService apiBrasilService,
            string postalCode)
        {
            var result =
                await apiBrasilService
                    .GetPostalCode(postalCode)
                    .ConfigureAwait(false);

            return Ok(result);
        }
    }
}