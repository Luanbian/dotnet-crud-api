using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class CreateProductController(ICreateProductProtocol create) : ControllerBase
    {
        private readonly ICreateProductProtocol create = create;

        [HttpPost]
        public IActionResult Handle()
        {
            Product product = create.Perform();
            return Ok(product);
        }
    }
}
