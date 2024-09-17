using FakeData.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FakeData.Data;

public class FakerContext : DbContext
{
    private readonly IConfiguration _configuration;

    public FakerContext(DbContextOptions<FakerContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Kullanıcı ve Ürün arasındaki çoka-çok ilişkiyi yapılandırma

        // Diğer model yapılandırmaları buraya eklenebilir
    }
}