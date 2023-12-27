using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class ListAllProduct(IFindRepository<Product> find) : IListAllProductProtocol
    {
        private readonly IFindRepository<Product> repository = find;
        public List<Product> Perform()
        {
            return repository.FindAll();
        }
    }
}
