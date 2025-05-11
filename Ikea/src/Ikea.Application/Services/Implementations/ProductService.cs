using AutoMapper;
using Ikea.Application.DTOs;
using Ikea.Application.DTOs.Request;
using Ikea.Application.DTOs.Response;
using Ikea.Domain.Entities;
using Ikea.Domain.Repositories;

namespace Ikea.Application.Services.Implementations;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductListResponseDto>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAllProductsAsync();
        return _mapper.Map<IEnumerable<ProductListResponseDto>>(products);
    }

    public async Task<ProductResponseDto?> GetProductByIdAsync(int id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);
        return product != null ? _mapper.Map<ProductResponseDto>(product) : null;
    }

    public async Task<ProductDetailsDto> CreateProductAsync(ProductRequestDto productDto)
    {
        var product = new Product
        {
            Name = productDto.Name,
            ProductTypeId = productDto.ProductType,
            CreatedAt = DateTime.UtcNow
        };

        foreach (var colourId in productDto.Colours)
        {
            product.ProductColours.Add(new ProductColour { ColourId = colourId });
        }

        var createdProduct = await _productRepository.CreateProductAsync(product);
        return _mapper.Map<ProductDetailsDto>(createdProduct);
    }
}
