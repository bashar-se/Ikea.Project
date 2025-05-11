using Ikea.Application.DTOs;
using Ikea.Application.DTOs.Response;
using Ikea.Application.DTOs.Request;

namespace Ikea.Application.Services;

public interface IProductService
{
    Task<IEnumerable<ProductListResponseDto>> GetAllProductsAsync();
    Task<ProductResponseDto?> GetProductByIdAsync(int id);
    Task<ProductDetailsDto> CreateProductAsync(ProductRequestDto productDto);
}
