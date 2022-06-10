using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Interest_API.Database
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base()
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}