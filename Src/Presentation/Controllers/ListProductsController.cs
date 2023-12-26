using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ListProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("tudo certo");
        }
    }
}
