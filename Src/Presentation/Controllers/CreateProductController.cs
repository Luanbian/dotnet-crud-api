using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    [Route("api/products/create")]
    [ApiController]
    public class CreateProductController : ControllerBase
    {
        private readonly ICreateProductProtocol create;
        private readonly ILogger<CreateProductController> logger;

        public CreateProductController (ICreateProductProtocol create, ILogger<CreateProductController> logger)
        {
            this.create = create;
            this.logger = logger;
        }

        [HttpPost]
        public IActionResult Handle()
        {
            logger.LogInformation("Chegou no controller");
            Product product = create.Perform();
            return Ok(product);
        }
    }
}
