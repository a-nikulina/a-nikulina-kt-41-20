using Microsoft.EntityFrameworkCore;
using nikulinakt41_20.Database.Configurations;
using nikulinakt41_20.Models;

namespace nikulinakt41_20.Database
{
    public class StudDbContext : DbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Group> Group { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupCofiguration());
        }
        public StudDbContext(DbContextOptions<StudDbContext> options) : base(options) 
        {

        }
    }
}
