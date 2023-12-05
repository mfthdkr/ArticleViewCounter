using Microsoft.EntityFrameworkCore;

namespace ArticleViewCounter.EntityFrameworkCore.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly IServiceProvider ServiceProvider;
        public Repository(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {   
            using(var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                var entity = await context.Set<T>().FindAsync(id);
                return entity;
            }
        }
        
    }
}
