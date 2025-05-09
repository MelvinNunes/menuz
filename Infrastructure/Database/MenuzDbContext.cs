using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class MenuzDbContext(DbContextOptions<MenuzDbContext> options) : DbContext(options)
{
    public DbSet<Configuration> Configurations => Set<Configuration>();
}