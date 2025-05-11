using Ikea.Domain.Entities;

namespace Ikea.Domain.Repositories;

public interface IProductTypeRepository
{
    Task<IEnumerable<ProductType>> GetAllProductTypesAsync();
}
