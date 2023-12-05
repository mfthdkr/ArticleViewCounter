using ArticleViewCounter.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArticleViewCounter.Extensions
{
    public static class BaseExtensionsForApp
    {
        public static void RunMigrationAutomatically(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                db.Database.Migrate();
            }
        }
    }
}
