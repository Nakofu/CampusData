using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class AttendanceWebContext : DbContext
{
    public AttendanceWebContext(DbContextOptions<AttendanceWebContext> options) : base(options)
    {
    }
    
    public DbSet<AttendanceWeb> Values { get; set; }
}