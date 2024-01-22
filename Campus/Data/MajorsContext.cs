using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class MajorsContext : DbContext
{
    public MajorsContext(DbContextOptions<MajorsContext> options) : base(options)
    {
    }
    
    public DbSet<Majors> Values { get; set; }
}