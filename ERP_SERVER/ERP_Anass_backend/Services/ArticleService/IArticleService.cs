using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.ArticleService
{
    public interface IArticleService
    {
        Article GetArticleById(int id);
        List<Article> GetArticles();
        List<dynamic> GetArticlesDetails();

        Article AddArticle(ArticleDtos article);
        Article UpdateArticle(int id,Article article);
        Article UpdateStock(Article ar);
        bool DeleteArticle(int id);
        List<Article> GetArticlesByPriceRange(float minPrice, float maxPrice);
        bool IsArticleInStock(int id);
    }
}
