using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class FundPrivilegeContext : DbContext
{
    public FundPrivilegeContext(DbContextOptions<FundPrivilegeContext> options) : base(options)
    {
    }
    
    public DbSet<FundPrivilege> Values { get; set; }
}