using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using System.Diagnostics;

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
            Debug.WriteLine("Chegou no controller");
            Product product = create.Perform();
            return Ok(product);
        }
    }
}
