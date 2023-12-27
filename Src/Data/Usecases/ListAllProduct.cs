using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.Repositories.Protocols;
using ProductManagement.API.Src.Presentation.Controllers;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class ListAllProduct(IFindRepository<Product> find) : IListAllProductProtocol
    {
        private readonly IFindRepository<Product> repository = find;
        public List<Product> Perform(GetAllControllerProps data)
        {
            return repository.FindBy(product =>
                product.Title == data.Title && 
                product.Price == data.Price &&
                product.Description == data.Description
            );
        }
    }
}
