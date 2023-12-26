namespace ProductManagement.API.Src.Domain.Entities
{
    public record ProductProps
    {
        public string Title { get; init; }

        public string? Description { get; init; }

        public int Price { get; init; }
    }
}
