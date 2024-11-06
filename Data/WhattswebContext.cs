using Microsoft.EntityFrameworkCore;
using dharmendraPradhan.Models;

namespace dharmendraPradhan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }  // DbSet for the Message model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Content field as a JSON column if supported by your database (e.g., PostgreSQL)
            modelBuilder.Entity<Message>()
                .Property(m => m.Content)
                .HasConversion(
                    v => string.Join(";", v),  // Example: Convert list to a semicolon-separated string
                    v => v.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList()
                );
        }
    }
}
