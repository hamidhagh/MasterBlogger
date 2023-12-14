using _01_Framework.Infrastructure;
using MB.Application.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository : IRepository<long, Article>
    {
        List<ArticleViewModel> GetList();

        //before refactory
        /*void CreatAndSave(Article entity);
        Article Get(long id);
        void Save();
        bool Exists(string title);*/
    }
}
