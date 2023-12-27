using Microsoft.EntityFrameworkCore;
using ProductManagement.API.Src.Domain.Entities;

namespace ProductManagement.API.Src.Infra.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Product>().Build();
            string connectionString = config.GetConnectionString("MyDatabaseConnection")
                ?? throw new InvalidOperationException("A string de conexão não pode ser nula."); ;
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
