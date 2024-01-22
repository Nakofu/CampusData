using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class PagesContext : DbContext
{
    public PagesContext(DbContextOptions<PagesContext> options) : base(options)
    {
    }
    
    public DbSet<Pages> Values { get; set; }
}