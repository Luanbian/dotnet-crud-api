using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFDeleteProduct(AppDbContext appDbContext) : IDeleteRepository
    {
        private readonly AppDbContext db = appDbContext;

        public void Delete(Guid id)
        {
            Product? product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Produto não encontrado");
            }
        }
    }
}
