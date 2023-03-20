using BookStore.Services.ProductAPI.EntityTypeConfiguration;
using BookStore.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Genre> Genre { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}