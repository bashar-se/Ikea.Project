using AutoMapper;
using Ikea.Application.DTOs.Response;
using Ikea.Domain.Repositories;

namespace Ikea.Application.Services.Implementations;

public class ProductTypeService : IProductTypeService
{
    private readonly IProductTypeRepository _productTypeRepository;
    private readonly IMapper _mapper;
    
    public ProductTypeService(IProductTypeRepository productTypeRepository, IMapper mapper)
    {
        _productTypeRepository = productTypeRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ProductTypeResponseDto>> GetAllProductTypesAsync()
    {
        var productTypes = await _productTypeRepository.GetAllProductTypesAsync();
        return _mapper.Map<IEnumerable<ProductTypeResponseDto>>(productTypes);
    }
}
