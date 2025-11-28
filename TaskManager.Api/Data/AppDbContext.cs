using Microsoft.EntityFrameworkCore;
using TaskManager.Api.Models;

namespace TaskManager.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks => Set<TaskItem>();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TaskItem>()
                .Property(x => x.Title).IsRequired().HasMaxLength(200);
            mb.Entity<TaskItem>()
                .Property(x => x.Priority).HasDefaultValue(3);
        }
    }
}
