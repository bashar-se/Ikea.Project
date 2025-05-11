namespace Ikea.Application.DTOs.Response;

public record ProductTypeResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}
