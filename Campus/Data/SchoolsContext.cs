using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class SchoolsContext : DbContext
{
    public SchoolsContext(DbContextOptions<SchoolsContext> options) : base(options)
    {
    }
    
    public DbSet<Schools> Values { get; set; }
}