using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFCreateProduct : ICreateRepository<Product>
    {
        private readonly AppDbContext repository;
        public EFCreateProduct(AppDbContext appDbContext) { 
            repository = appDbContext;
        }
        public async Task<Product> Exec(Product data)
        {
           repository.Products.Add(data);
           await repository.SaveChangesAsync();
           return data;
        }
    }
}
