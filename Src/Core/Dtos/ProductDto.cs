namespace ProductManagement.API.Src.Core.Dtos
{
    public record ProductDto
    {
        public string Title { get; init; }

        public string? Description { get; init; }

        public int Price { get; init; }
    }
}
