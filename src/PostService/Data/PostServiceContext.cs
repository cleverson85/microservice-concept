using Microsoft.EntityFrameworkCore;
using PostService.Entities;

namespace PostService.Data
{
    public class PostServiceContext : DbContext
    {
        public DbSet<Post> Post { get; set; }
        public DbSet<User> User { get; set; }

        public PostServiceContext(DbContextOptions<PostServiceContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
