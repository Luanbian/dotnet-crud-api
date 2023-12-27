using ProductManagement.API.Src.Core.Dtos;
using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class CreateProduct(ICreateRepository<Product> repository) : ICreateProductProtocol
    {
        private readonly ICreateRepository<Product> create = repository;

        public Product Perform(ProductDto data)
        {
            ProductDto props = new()
            { 
                Title = data.Title,
                Description = data.Description,
                Price = data.Price
            };
            Product product = Product.Create (props);
            create.Exec(product);
            return product;
        }
    }
}
