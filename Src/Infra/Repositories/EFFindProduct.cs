using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;
using System.Linq.Expressions;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFFindProduct(AppDbContext appDbContext) : IFindRepository<Product>
    {
        private readonly AppDbContext db = appDbContext;

        public List<Product> FindAll()
        {
            return [.. db.Products];
        }

        public List<Product> FindBy(Expression<Func<Product, bool>> filter)
        {
            return [.. db.Products.Where(filter)];
        }
    }
}
