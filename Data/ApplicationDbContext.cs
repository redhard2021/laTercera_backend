using laTercera.Models;
using Microsoft.EntityFrameworkCore;

namespace laTercera;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    
    public DbSet<Models.Field>? Field { get; set; }
    public DbSet<Tournament>? Tournament { get; set; }
    public DbSet<Match>? Match { get; set; }
    public DbSet<Organizer>? Organizer { get; set; }
    public DbSet<Team>? Team { get; set; }
}