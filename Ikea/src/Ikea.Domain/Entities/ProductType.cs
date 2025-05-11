namespace Ikea.Domain.Entities;

public class ProductType
{
    public int Id { get; set; }
    public required string Name { get; set; }
    
    // Navigation properties
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
