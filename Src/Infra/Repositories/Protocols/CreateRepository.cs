namespace ProductManagement.API.Src.Infra.Repositories.Protocols
{
    public interface ICreateRepository<T>
    {
        void Exec(T data);
    }
}
