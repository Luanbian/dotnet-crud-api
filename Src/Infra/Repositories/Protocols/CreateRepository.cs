namespace ProductManagement.API.Src.Infra.Repositories.Protocols
{
    public interface ICreateRepository<T>
    {
        Task<T> Exec(T data);
    }
}
