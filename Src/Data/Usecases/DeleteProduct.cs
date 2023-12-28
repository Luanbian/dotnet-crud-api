using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class DeleteProduct(IDeleteRepository delete) : IDeleteProductProtocol
    {
        private readonly IDeleteRepository repository = delete;
        public void Perform(string id)
        {
            repository.Delete(id);
        }
    }
}
