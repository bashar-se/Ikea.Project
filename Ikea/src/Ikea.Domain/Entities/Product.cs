using System.ComponentModel.DataAnnotations.Schema;

namespace Ikea.Domain.Entities;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public required string Name { get; set; }
    public int ProductTypeId { get; set; }
    public DateTime CreatedAt { get; set; }
    
    // Navigation properties
    public ProductType? ProductType { get; set; }
    public ICollection<ProductColour> ProductColours { get; set; } = new List<ProductColour>();
}
