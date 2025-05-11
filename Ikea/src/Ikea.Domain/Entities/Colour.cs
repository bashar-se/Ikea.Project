namespace Ikea.Domain.Entities;

public class Colour
{
    public int Id { get; set; }
    public required string Name { get; set; }
    
    // Navigation properties
    public ICollection<ProductColour> ProductColours { get; set; } = new List<ProductColour>();
}
