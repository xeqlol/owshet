using Owshet.Repositories.Abstractions;

namespace Owshet.Repositories.Seedworks
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext dbContext;

        public UnitOfWork(BlogContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Commit()
        {
            dbContext.Commit();
        }
    }
}
