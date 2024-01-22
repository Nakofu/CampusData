using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class HonoursContext : DbContext
{
    public HonoursContext(DbContextOptions<HonoursContext> options) : base(options)
    {
    }
    
    public DbSet<Honours> Values { get; set; }
}