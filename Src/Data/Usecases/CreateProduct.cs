using ProductManagement.API.Src.Core.Dtos;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class CreateProduct(ICreateRepository<Product> repository) : ICreateProductProtocol
    {
        private readonly ICreateRepository<Product> create = repository;

        public Product Perform()
        {
            ProductDto props = new()
            { 
                Title = "titulo de teste",
                Description = "Description teste",
                Price = 1
            };
            Product product = Product.Create (props);
            create.Exec(product);
            return product;
        }
    }
}
