namespace ProductManagement.API.Src.Domain.Entities
{
    public class Product
    {
        private Guid Id { get; set; }
        private string Title { get; set; }

        private string? Description { get; set; }

        private int Price { get; set; }

        private Product (ProductProps props)
        {
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
