using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Presentation.Controllers;

namespace ProductManagement.API.Src.Data.Protocols
{
    public interface IUpdateProductProtocol
    {
        void Perform(string id, UpdateControllerProps data);
    }
}
