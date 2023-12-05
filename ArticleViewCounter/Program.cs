using ArticleViewCounter.EntityFrameworkCore;
using ArticleViewCounter.EntityFrameworkCore.Repositories;
using ArticleViewCounter.Extensions;
using ArticleViewCounter.Hubs;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Scoped servislerin (ApplicationContext),  Singleton servislerde nasýl kullanýldýðýný göstermek için AddSingleton tanýmlandý. 
builder.Services.AddSingleton<IArticleRepository, ArticleRepository>();

var app = builder.Build();

app.RunMigrationAutomatically(); // Migration'ý otomatik olarak yapar.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapHub<ArticleHub>("/articleHub");

app.Run();
