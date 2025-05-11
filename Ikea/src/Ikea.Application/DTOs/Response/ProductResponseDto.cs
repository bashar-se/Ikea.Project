namespace Ikea.Application.DTOs.Response
{
    public record ProductResponseDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public ProductTypeResponseDto ProductType { get; init; } = new ProductTypeResponseDto();
        public IEnumerable<ColourResponseDto> Colours { get; init; } = Array.Empty<ColourResponseDto>();
    }
}
