using ArticleViewCounter.Entities;

namespace ArticleViewCounter.EntityFrameworkCore.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
           
        }
        public async Task<int> IncreaseNumberOfWiewByOne(int articleId)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                var article = await context.Set<Article>().FindAsync(articleId);
                int value;

                if (article is null)
                    value = 0;
                else
                {
                    article.NumberOfViews++;
                    context.SaveChanges();
                    value = article.NumberOfViews;
                }

                return value;
            }
        }
    }

}
