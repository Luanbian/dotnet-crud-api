using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFCreateProduct(AppDbContext appDbContext) : ICreateRepository<Product>
    {
        private readonly AppDbContext db = appDbContext;

        public void Exec(Product data)
        {
           db.Products.Add(data);
           db.SaveChanges();
        }
    }
}
