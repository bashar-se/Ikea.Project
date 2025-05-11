namespace Ikea.Domain.Entities;

public class ProductColour
{
    public int ProductId { get; set; }
    public int ColourId { get; set; }
    
    // Navigation properties
    public Product? Product { get; set; }
    public Colour? Colour { get; set; }
}
