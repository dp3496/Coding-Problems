using Microsoft.EntityFrameworkCore;

namespace Hackerrank
{
    public class HackerrankContext : DbContext
    {
        public DbSet<Problem> Problems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase("test-db"); 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Problem>(entity => {
                entity.HasIndex(e => e.Id, "IX_Problem_Id");
                entity.Property(bs => bs.Name);
            });
        }
        
    }
    
    public class Problem
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }
}