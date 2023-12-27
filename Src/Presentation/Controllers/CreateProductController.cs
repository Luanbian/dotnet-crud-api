using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.Src.Core.Dtos;
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
        public IActionResult Handle([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Product product = create.Perform(productDto);
                return Ok(product);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
