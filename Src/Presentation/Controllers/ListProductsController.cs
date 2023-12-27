using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Presentation.Controllers
{
    public record GetAllControllerProps(
        string? Title,
        string? Description,
        int? Price
    ) {}

    [Route("api/products")]
    [ApiController]
    public class ListProductsController(IListAllProductProtocol list) : ControllerBase
    {
        private readonly IListAllProductProtocol list = list;

        [HttpGet]
        public IActionResult GetAll([FromQuery] GetAllControllerProps props)
        {
            List<Product> products = list.Perform(props);
            return Ok(products);
        }
    }
}
