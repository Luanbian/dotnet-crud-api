using ProductManagement.API.Src.Core.Dtos;

namespace ProductManagement.API.Src.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        public Product() {}

        private Product(ProductDto props) 
        {
            Title = props.Title;
            Description = props.Description;
            Price = props.Price;
        }

        public static Product Create(ProductDto props) 
        { 
            return new Product (props);
        }
    }
}
