using BlzCrd.Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlzCrd.Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = null!;
}