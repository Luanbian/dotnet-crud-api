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
            if (product != null)
            {
                if (data.Title != null) product.Title = data.Title;
                else product.Title = product.Title;

                if (data.Description != null) product.Description = data.Description;
                else product.Description = product.Description;

                if (data.Price != null) product.Price = (int)data.Price;
                else product.Price = product.Price;

                db.Products.Update(product);
                db.SaveChanges();
            }
        }
    }
}
