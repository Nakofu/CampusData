using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class FundBonusContext : DbContext
{
    public FundBonusContext(DbContextOptions<FundBonusContext> options) : base(options)
    {
    }
    
    public DbSet<FundBonus> Values { get; set; }
}