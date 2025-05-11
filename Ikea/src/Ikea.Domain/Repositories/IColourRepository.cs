using Ikea.Domain.Entities;

namespace Ikea.Domain.Repositories;

public interface IColourRepository
{
    Task<IEnumerable<Colour>> GetAllColoursAsync();
}
