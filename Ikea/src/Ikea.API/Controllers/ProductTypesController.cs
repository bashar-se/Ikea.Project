using Ikea.Application.DTOs.Response;
using Ikea.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ikea.API.Controllers;

[ApiController]
[Route("api/producttypes")]
public class ProductTypesController : ControllerBase
{
    private readonly IProductTypeService _productTypeService;
    
    public ProductTypesController(IProductTypeService productTypeService)
    {
        _productTypeService = productTypeService;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ProductTypeResponseDto>>> GetAllProductTypes()
    {
        var productTypes = await _productTypeService.GetAllProductTypesAsync();
        return Ok(productTypes);
    }
}
