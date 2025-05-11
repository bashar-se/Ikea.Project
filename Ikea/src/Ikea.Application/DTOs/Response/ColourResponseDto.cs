namespace Ikea.Application.DTOs.Response;

public record ColourResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}
