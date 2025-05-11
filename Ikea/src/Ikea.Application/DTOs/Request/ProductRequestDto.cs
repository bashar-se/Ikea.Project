namespace Ikea.Application.DTOs.Request;

public record ProductRequestDto
{
    public required string Name { get; init; }
    public int ProductType { get; init; }
    public IEnumerable<int> Colours { get; init; } = Array.Empty<int>();
}
