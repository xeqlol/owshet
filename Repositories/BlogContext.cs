using Microsoft.EntityFrameworkCore;
using Owshet.Entities;

namespace Owshet.Repositories
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base() { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(x => new { x.PostId, x.TagId });
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
