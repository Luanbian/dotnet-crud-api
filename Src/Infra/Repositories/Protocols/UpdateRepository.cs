using ProductManagement.API.Src.Presentation.Controllers;

namespace ProductManagement.API.Src.Infra.Repositories.Protocols
{
    public interface IUpdateRepository<T>
    {
        void Update(Guid id, T data);
    }
}
