using ProductManagement.API.Src.Core.Dtos;

namespace ProductManagement.API.Src.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        private Product (ProductDto props)
        {
            Id = Guid.NewGuid();
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
