using Ikea.Domain.Entities;
using Ikea.Domain.Repositories;
using Ikea.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ikea.Infrastructure.Repositories;

public class ProductTypeRepository : IProductTypeRepository
{
    private readonly ApplicationDbContext _context;
    
    public ProductTypeRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<ProductType>> GetAllProductTypesAsync()
    {
        return await _context.ProductTypes.ToListAsync();
    }
}
