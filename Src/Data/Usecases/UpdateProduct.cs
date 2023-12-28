using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.Repositories.Protocols;
using ProductManagement.API.Src.Presentation.Controllers;

namespace ProductManagement.API.Src.Data.Usecases
{
    public class UpdateProduct(IUpdateRepository<UpdateControllerProps> update) : IUpdateProductProtocol
    {
        private readonly IUpdateRepository<UpdateControllerProps> repository = update;
        public void Perform(string id, UpdateControllerProps data)
        {
            repository.Update(new Guid(id), data);
        }
    }
}
