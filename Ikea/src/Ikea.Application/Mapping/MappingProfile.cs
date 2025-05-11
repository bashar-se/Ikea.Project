using AutoMapper;
using Ikea.Application.DTOs;
using Ikea.Application.DTOs.Response;
using Ikea.Domain.Entities;

namespace Ikea.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDetailsDto>()
            .ForMember(dest => dest.ProductTypeName, opt => opt.MapFrom(src => src.ProductType != null ? src.ProductType.Name : string.Empty))
            .ForMember(dest => dest.Colours, opt => opt.MapFrom(src => src.ProductColours.Select(pc => pc.Colour)));

        CreateMap<Product, ProductResponseDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.ProductType, opt => opt.MapFrom(src => src.ProductType))
            .ForMember(dest => dest.Colours, opt => opt.MapFrom(src =>
                src.ProductColours.Where(pc => pc.Colour != null).Select(pc => pc.Colour)));

        CreateMap<Product, ProductListResponseDto>();

        CreateMap<ProductType, ProductTypeResponseDto>();
        
        CreateMap<Colour, ColourResponseDto>();
    }
}