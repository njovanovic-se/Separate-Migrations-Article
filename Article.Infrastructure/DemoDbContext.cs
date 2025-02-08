using Article.Domain.Model;
using Medium.Separating.Migrations.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Medium.Separating.Migrations.Infrastructure
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }
    }
}
