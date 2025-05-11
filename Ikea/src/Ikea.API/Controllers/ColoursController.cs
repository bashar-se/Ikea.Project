using Ikea.Application.DTOs.Response;
using Ikea.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ikea.API.Controllers;

[ApiController]
[Route("api/colours")]
public class ColoursController : ControllerBase
{
    private readonly IColourService _colourService;
    
    public ColoursController(IColourService colourService)
    {
        _colourService = colourService;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ColourResponseDto>>> GetAllColours()
    {
        var colours = await _colourService.GetAllColoursAsync();
        return Ok(colours);
    }
}
