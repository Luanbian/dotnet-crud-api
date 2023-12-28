using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFDeleteProduct(AppDbContext appDbContext) : IDeleteRepository
    {
        private readonly AppDbContext db = appDbContext;

        public void Delete(string id)
        {
            db.Remove(id);
        }
    }
}
