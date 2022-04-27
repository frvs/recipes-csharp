using Microsoft.AspNetCore.Mvc;

namespace Recipes.Api.Controllers
{
    [Route("test")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
