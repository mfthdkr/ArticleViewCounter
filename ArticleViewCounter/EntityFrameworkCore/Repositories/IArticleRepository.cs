using ArticleViewCounter.Entities;

namespace ArticleViewCounter.EntityFrameworkCore.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        Task<int> IncreaseNumberOfWiewByOne(int articleId);
    }
}
