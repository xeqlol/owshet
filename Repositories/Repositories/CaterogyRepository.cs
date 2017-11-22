using Owshet.Repositories;
using Owshet.Repositories.Abstractions;
using Owshet.Entities;
using System.Linq;

namespace Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogContext dbContext) : base(dbContext)
        {
        
        }

        public Category GetCategoryByName(string categoryName)
        {
            var category = dbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return category;
        }
    }

    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
