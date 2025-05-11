using Ikea.Application.DTOs.Response;

namespace Ikea.Application.Services;

public interface IProductTypeService
{
    Task<IEnumerable<ProductTypeResponseDto>> GetAllProductTypesAsync();
}
