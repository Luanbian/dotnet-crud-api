using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Data.Protocols
{
    public interface ICreateProductProtocol
    {
        Product Perform();
    }
}
