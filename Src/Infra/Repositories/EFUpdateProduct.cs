using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories.Protocols;
using ProductManagement.API.Src.Presentation.Controllers;

namespace ProductManagement.API.Src.Infra.Repositories
{
    public class EFUpdateProduct(AppDbContext appDbContext) : IUpdateRepository<UpdateControllerProps>
    {
        private readonly AppDbContext db = appDbContext;

        public void Update(Guid id, UpdateControllerProps data)
        {
            Product? product = db.Products.Find(id);
            if (product == null) return;

            product.Title = data.Title ?? product.Title;
            product.Description = data.Description ?? product.Description;
            product.Price = data.Price ?? product.Price;

            db.Products.Update(product);
            db.SaveChanges();
            
        }
    }
}
