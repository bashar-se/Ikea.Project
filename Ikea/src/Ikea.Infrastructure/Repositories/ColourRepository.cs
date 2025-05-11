using Ikea.Domain.Entities;
using Ikea.Domain.Repositories;
using Ikea.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ikea.Infrastructure.Repositories;

public class ColourRepository : IColourRepository
{
    private readonly ApplicationDbContext _context;
    
    public ColourRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Colour>> GetAllColoursAsync()
    {
        return await _context.Colours.ToListAsync();
    }
}
