using Owshet.Repositories.Abstractions;
using Owshet.Entities;
using System.Linq;

namespace Owshet.Repositories.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(BlogContext dbContext) : base(dbContext)
        {

        }

        public Post GetPostBySlug(string slug)
        {
            var post = dbContext.Posts.Where(c => c.Slug == slug).FirstOrDefault();
            return post;
        }
    }

    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostBySlug(string slug);
    }
}
