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
            if (data == null) return repository.FindAll();
            return repository.FindBy(product =>
                (data.Title == null || product.Title == data.Title) &&
                (!data.Price.HasValue || product.Price == data.Price) &&
                (data.Description == null || product.Description == data.Description)
            );
        }
    }
}
