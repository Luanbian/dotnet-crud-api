using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    public record UpdateControllerProps(
        string? Title,
        string? Description,
        int? Price
    ) {}

    [Route("api/products")]
    [ApiController]
    public class UpdateProductController(IUpdateProductProtocol update) : ControllerBase
    {
        private readonly IUpdateProductProtocol update = update;

        [HttpPut]
        public IActionResult UpdateProduct([FromQuery] string id, [FromBody] UpdateControllerProps data)
        {
            try
            {
            update.Perform(id, data);
            return Ok("Atualizado");
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
