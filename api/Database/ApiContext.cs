using Microsoft.EntityFrameworkCore;
using rift.Models;
namespace rift.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<User>().ToTable("User");
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<User> User { get; set; }
    }
}