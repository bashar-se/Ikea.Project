using Ikea.Domain.Entities;
using Ikea.Domain.Repositories;
using Ikea.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ikea.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.ProductColours)
                .ThenInclude(pc => pc.Colour)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();
    }
    
    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.ProductColours)
                .ThenInclude(pc => pc.Colour)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<Product> CreateProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        
        await _context.Entry(product)
            .Reference(p => p.ProductType)
            .LoadAsync();
        
        await _context.Entry(product)
            .Collection(p => p.ProductColours)
            .LoadAsync();
        
        foreach (var productColour in product.ProductColours)
        {
            await _context.Entry(productColour)
                .Reference(pc => pc.Colour)
                .LoadAsync();
        }
        
        return product;
    }
}
