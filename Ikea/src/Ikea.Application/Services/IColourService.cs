using Ikea.Application.DTOs.Response;

namespace Ikea.Application.Services;

public interface IColourService
{
    Task<IEnumerable<ColourResponseDto>> GetAllColoursAsync();
}
