using Owshet.Repositories.Abstractions;
using Owshet.Entities;
using System.Linq;


namespace Owshet.Repositories.Repositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(BlogContext dbContext) : base(dbContext)
        {
        
        }

        public Tag GetTagByName(string name)
        {
            var tag = dbContext.Tags.Where(t => t.Name == name).FirstOrDefault();
            return tag;
        } 
    }

    public interface ITagRepository
    {
        Tag GetTagByName(string name);
    }
}
