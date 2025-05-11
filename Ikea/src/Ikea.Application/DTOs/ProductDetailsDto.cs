using Ikea.Application.DTOs.Response;

namespace Ikea.Application.DTOs;

public record ProductDetailsDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public int ProductTypeId { get; init; }
    public string ProductTypeName { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public IEnumerable<ColourResponseDto> Colours { get; init; } = Array.Empty<ColourResponseDto>();
}
