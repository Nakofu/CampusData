using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class ApplicationsContext : DbContext
{
    public ApplicationsContext(DbContextOptions<ApplicationsContext> options) : base(options)
    {
    }
    
    public DbSet<Applications> Values { get; set; }
}