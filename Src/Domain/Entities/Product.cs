namespace ProductManagement.API.Src.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        private Product (ProductProps props)
        {
            Id = Guid.NewGuid();
            Title = props.Title;
            Description = props.Description;
            Price = props.Price;
        }

        public static Product Create(ProductProps props) 
        { 
            return new Product (props);
        }
    }
}
