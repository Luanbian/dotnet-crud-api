using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteProductController(IDeleteProductProtocol delete) : ControllerBase
    {
        private readonly IDeleteProductProtocol delete = delete;

        [HttpDelete]
        public IActionResult Delete([FromQuery] string id)
        {
            delete.Perform(id);
            return Ok("deletado com sucesso");
        }
    }
}
