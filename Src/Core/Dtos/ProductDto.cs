using System.ComponentModel.DataAnnotations;

namespace ProductManagement.API.Src.Core.Dtos
{
    public record ProductDto
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; init; }

        public string? Description { get; init; }

        [Range(0, int.MaxValue, ErrorMessage = "Preço deve ser positivo")]
        [Required(ErrorMessage = "Preço é obrigatório")]
        public int Price { get; init; }
    }
}
