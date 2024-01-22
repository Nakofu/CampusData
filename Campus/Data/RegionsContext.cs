using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class RegionsContext : DbContext
{
    public RegionsContext(DbContextOptions<RegionsContext> options) : base(options)
    {
    }
    
    public DbSet<Regions> Values { get; set; }
}