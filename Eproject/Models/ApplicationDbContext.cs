// ApplicationDbContext.cs
using Eproject.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<admin> admin { get; set; }
    public DbSet<users> users { get; set; }
    public DbSet<shop> Shops { get; set; }
}
