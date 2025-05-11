using AutoMapper;
using Ikea.Application.DTOs.Response;
using Ikea.Domain.Repositories;

namespace Ikea.Application.Services.Implementations;

public class ColourService : IColourService
{
    private readonly IColourRepository _colourRepository;
    private readonly IMapper _mapper;
    
    public ColourService(IColourRepository colourRepository, IMapper mapper)
    {
        _colourRepository = colourRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ColourResponseDto>> GetAllColoursAsync()
    {
        var colours = await _colourRepository.GetAllColoursAsync();
        return _mapper.Map<IEnumerable<ColourResponseDto>>(colours);
    }
}
