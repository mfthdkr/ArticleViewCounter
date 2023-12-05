using ArticleViewCounter.EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace ArticleViewCounter.Hubs
{
    public class ArticleHub : Hub
    {
        private readonly IServiceProvider _serviceProvider;
        public ArticleHub(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task IncreaseViewCount(int articleId)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var articleRepository = scope.ServiceProvider.GetRequiredService<IArticleRepository>();
                var newCount = (await articleRepository.GetByIdAsync(articleId)).NumberOfViews;
                await Clients.All.SendAsync("ReceiveViewCount", articleId, newCount);
            }
        }

    }
}
