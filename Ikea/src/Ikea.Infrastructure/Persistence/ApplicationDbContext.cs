using Ikea.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ikea.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductType> ProductTypes => Set<ProductType>();
    public DbSet<Colour> Colours => Set<Colour>();
    public DbSet<ProductColour> ProductColours => Set<ProductColour>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureProductEntity(modelBuilder);
        ConfigureProductTypeEntity(modelBuilder);
        ConfigureColourEntity(modelBuilder);
        ConfigureProductColourEntity(modelBuilder);
        
        SeedData(modelBuilder);
    }
    
    private static void ConfigureProductEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Id).UseIdentityColumn();
            entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
            entity.Property(p => p.CreatedAt).IsRequired();
            
            entity.HasOne(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.ProductTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
    
    private static void ConfigureProductTypeEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(pt => pt.Id);
            entity.Property(pt => pt.Id).UseIdentityColumn();
            entity.Property(pt => pt.Name).IsRequired().HasMaxLength(50);
        });
    }
    
    private static void ConfigureColourEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Colour>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).UseIdentityColumn();
            entity.Property(c => c.Name).IsRequired().HasMaxLength(50);
        });
    }
    
    private static void ConfigureProductColourEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductColour>(entity =>
        {
            entity.HasKey(pc => new { pc.ProductId, pc.ColourId });
            
            entity.HasOne(pc => pc.Product)
                .WithMany(p => p.ProductColours)
                .HasForeignKey(pc => pc.ProductId);
            
            entity.HasOne(pc => pc.Colour)
                .WithMany(c => c.ProductColours)
                .HasForeignKey(pc => pc.ColourId);
        });
    }
    
    private static void SeedData(ModelBuilder modelBuilder)
    {
        // Seed ProductTypes
        modelBuilder.Entity<ProductType>().HasData(
            new ProductType { Id = 1, Name = "Chair" },
            new ProductType { Id = 2, Name = "Table" },
            new ProductType { Id = 3, Name = "Bed" },
            new ProductType { Id = 4, Name = "Sofa" },
            new ProductType { Id = 5, Name = "Bookshelf" },
            new ProductType { Id = 6, Name = "Desk" },
            new ProductType { Id = 7, Name = "Wardrobe" },
            new ProductType { Id = 8, Name = "Dresser" },
            new ProductType { Id = 9, Name = "TV Stand" },
            new ProductType { Id = 10, Name = "Coffee Table" },
            new ProductType { Id = 11, Name = "Dining Set" },
            new ProductType { Id = 12, Name = "Nightstand" },
            new ProductType { Id = 13, Name = "Armchair" },
            new ProductType { Id = 14, Name = "Kitchen Cabinet" },
            new ProductType { Id = 15, Name = "Bathroom Vanity" },
            new ProductType { Id = 16, Name = "Storage Unit" },
            new ProductType { Id = 17, Name = "Lamp" },
            new ProductType { Id = 18, Name = "Rug" },
            new ProductType { Id = 19, Name = "Mirror" },
            new ProductType { Id = 20, Name = "Picture Frame" },
            new ProductType { Id = 21, Name = "Plant Pot" },
            new ProductType { Id = 22, Name = "Curtains" },
            new ProductType { Id = 23, Name = "Pillow" },
            new ProductType { Id = 24, Name = "Blanket" },
            new ProductType { Id = 25, Name = "Mattress" },
            new ProductType { Id = 26, Name = "Office Chair" },
            new ProductType { Id = 27, Name = "Shelf Unit" },
            new ProductType { Id = 28, Name = "Side Table" },
            new ProductType { Id = 29, Name = "Dining Chair" },
            new ProductType { Id = 30, Name = "Stool" },
            new ProductType { Id = 31, Name = "Room Divider" },
            new ProductType { Id = 32, Name = "Wall Shelf" },
            new ProductType { Id = 33, Name = "Kitchen Island" },
            new ProductType { Id = 34, Name = "Bar Stool" },
            new ProductType { Id = 35, Name = "Daybed" }
        );
        
        // Seed Colours
        modelBuilder.Entity<Colour>().HasData(
            new Colour { Id = 1, Name = "Black" },
            new Colour { Id = 2, Name = "White" },
            new Colour { Id = 3, Name = "Brown" },
            new Colour { Id = 4, Name = "Blue" },
            new Colour { Id = 5, Name = "Red" },
            new Colour { Id = 6, Name = "Green" },
            new Colour { Id = 7, Name = "Yellow" },
            new Colour { Id = 8, Name = "Orange" },
            new Colour { Id = 9, Name = "Purple" },
            new Colour { Id = 10, Name = "Pink" },
            new Colour { Id = 11, Name = "Gray" },
            new Colour { Id = 12, Name = "Silver" },
            new Colour { Id = 13, Name = "Gold" },
            new Colour { Id = 14, Name = "Beige" },
            new Colour { Id = 15, Name = "Turquoise" },
            new Colour { Id = 16, Name = "Teal" },
            new Colour { Id = 17, Name = "Navy" },
            new Colour { Id = 18, Name = "Maroon" },
            new Colour { Id = 19, Name = "Olive" },
            new Colour { Id = 20, Name = "Mint" },
            new Colour { Id = 21, Name = "Coral" },
            new Colour { Id = 22, Name = "Indigo" },
            new Colour { Id = 23, Name = "Magenta" },
            new Colour { Id = 24, Name = "Violet" },
            new Colour { Id = 25, Name = "Cyan" },
            new Colour { Id = 26, Name = "Burgundy" },
            new Colour { Id = 27, Name = "Lavender" },
            new Colour { Id = 28, Name = "Cream" },
            new Colour { Id = 29, Name = "Salmon" },
            new Colour { Id = 30, Name = "Charcoal" }
        );
    }
}
