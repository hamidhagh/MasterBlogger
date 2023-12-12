using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MB.Presentation.MVCCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}




/*using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.Core;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
builder.Services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
var connectionString = builder.Configuration.GetConnectionString("MasterBloggerDB");
builder.Services.AddDbContext<MasterBloggerContext>(x => x.UseSqlServer(connectionString));
//builder.Bootstrapper.Config(services, Configuration.GetConnectionString("MasterBloggerDB"));
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapDefaultControllerRoute();
});

app.MapRazorPages();

app.Run();
*/