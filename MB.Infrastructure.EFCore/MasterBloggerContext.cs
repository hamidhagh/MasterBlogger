using Microsoft.EntityFrameworkCore;
using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Infrastructure.EFCore.Mappings;
using MB.Domain.ArticleAgg;
using MB.Domain.CommentAgg;

namespace MB.Infrastructure.EFCore
{
    public class MasterBloggerContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(ArticleMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new CommentMapping());
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
