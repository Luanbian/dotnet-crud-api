using System.Linq.Expressions;

namespace ProductManagement.API.Src.Infra.Repositories.Protocols
{
    public interface IFindRepository<T>
    {
        List<T> FindAll();
        List<T> FindBy(Expression<Func<T, bool>> filter);
    }
}
