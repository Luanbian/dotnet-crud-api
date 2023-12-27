using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Data.Protocols
{
    public interface IListAllProductProtocol
    {
        List<Product> Perform();
    }
}
