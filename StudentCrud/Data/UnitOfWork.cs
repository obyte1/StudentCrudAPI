
using Microsoft.Extensions.DependencyInjection;

namespace StudentCrud.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDBContext _dbContext;
        public UnitOfWork(IServiceProvider provider)
        {
            _dbContext = provider.GetService<MainDBContext>();
        }

        public async Task SavechangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
