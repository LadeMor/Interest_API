using System.Reflection;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Interest_API.Database
{
    public class InterestContext : DbContext
    {
        public InterestContext(DbContextOptions<InterestContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}