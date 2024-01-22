using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class AttendanceMobileContext : DbContext
{
    public AttendanceMobileContext(DbContextOptions<AttendanceMobileContext> options) : base(options)
    {
    }
    
    public DbSet<AttendanceMobile> Values { get; set; }
}