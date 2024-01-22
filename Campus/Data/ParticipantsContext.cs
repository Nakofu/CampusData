using Campus.Models;
using Microsoft.EntityFrameworkCore;

namespace Campus.Data;

public class ParticipantsContext : DbContext
{
    public ParticipantsContext(DbContextOptions<ParticipantsContext> options) : base(options)
    {
    }
    
    //protected override void OnModelCreating(ModelBuilder modelBuilder){
    //    modelBuilder.Entity<Participants>()
    //        .Property(p => p.Id)
    //        .ValueGeneratedOnAdd();
    //}
    
    public DbSet<Participants> Values { get; set; }
}