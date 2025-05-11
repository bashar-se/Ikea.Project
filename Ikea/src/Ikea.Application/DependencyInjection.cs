using System.Reflection;
using Ikea.Application.Services;
using Ikea.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Ikea.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IColourService, ColourService>();
        services.AddScoped<IProductTypeService, ProductTypeService>();
        
        return services;
    }
}
