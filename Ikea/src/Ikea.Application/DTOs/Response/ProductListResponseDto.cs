namespace Ikea.Application.DTOs.Response;

public record ProductListResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}