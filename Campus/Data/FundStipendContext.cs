using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class FundStipendContext : DbContext
{
    public FundStipendContext(DbContextOptions<FundStipendContext> options) : base(options)
    {
    }
    
    public DbSet<FundStipend> Values { get; set; }
}