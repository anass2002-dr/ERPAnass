using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.ArticleRepo
{
    public interface IRepoArticle
    {
        Article GetArticleById(int id);
        List<dynamic> GetArticlesDetails();
        List<Article> GetArticles();
        Article AddArticle(Article article);
        Article UpdateArticle(Article article);
        Article UpdateStock(int quantity,int idArticle);
        Boolean DeleteArticle(int id);
    }
}
