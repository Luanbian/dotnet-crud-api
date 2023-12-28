namespace ProductManagement.API.Src.Infra.Repositories.Protocols
{
    public interface IDeleteRepository
    {
        void Delete(Guid id);
    }
}
