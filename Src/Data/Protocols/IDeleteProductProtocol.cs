namespace ProductManagement.API.Src.Data.Protocols
{
    public interface IDeleteProductProtocol
    {
        void Perform(string id);
    }
}
