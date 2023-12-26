using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class CreateProduct : ICreateProductProtocol
    {
        public Product Perform () 
        {
            ProductProps props = new()
            { 
                Title = "titulo de teste",
                Description = "Description teste",
                Price = 1
            };
            Product product = Product.Create (props);
            return product;
        }
    }
}
