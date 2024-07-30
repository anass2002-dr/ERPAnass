using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.ArticleRepo;
using ERP_Anass_backend.Repository.FamilyRepo;

namespace ERP_Anass_backend.Services.ArticleService
{
    public class ArticleService:IArticleService
    {
        private readonly IRepoArticle _repoArticle;
        private readonly IFamillyRepo _repoFamilly;

        public ArticleService(IRepoArticle repoArticle, IFamillyRepo repoFamilly)
        {
            _repoArticle = repoArticle;
            _repoFamilly = repoFamilly;

        }

        public Article GetArticleById(int id)
        {
            return _repoArticle.GetArticleById(id);
        }

     
        public List<Article> GetArticles()
        {
            return _repoArticle.GetArticles();
        }
        public List<dynamic> GetArticlesDetails()
        {
            return _repoArticle.GetArticlesDetails();
        }
        public Article AddArticle(Article article)
        {
            return _repoArticle.AddArticle(article);
        }

        //public Article UpdateArticle(int id, ArticleDtos articleDto)
        //{
        //    var article = _repoArticle.GetArticleById(id);
        //    if (article == null)
        //    {
        //        throw new KeyNotFoundException("Article not found");
        //    }

        //    if (articleDto.ArticleRef != "")
        //    {
        //        article.ArticleRef = articleDto.ArticleRef;
        //    }

        //    if (articleDto.ArticleName != "")
        //    {
        //        article.ArticleName = articleDto.ArticleName;
        //    }

        //    if (articleDto.DescriptionArticle != "")
        //    {
        //        article.DescriptionArticle = articleDto.DescriptionArticle;
        //    }

        //    if (articleDto.FamilyID != 0)
        //    {
        //        var familly = _repoFamilly.GetFamilyById(articleDto.FamilyID);
        //        if (familly != null)
        //        {
        //            article.FamilyID = articleDto.FamilyID;
        //        }
        //    }

        //    if (articleDto.StockQuantity != 0)
        //    {
        //        article.StockQuantity = articleDto.StockQuantity;
        //    }

        //    return _repoArticle.UpdateArticle(article);
        //}
        public Article UpdateArticle(int id, Article article)
        {
            article.idArticle = id;
            return _repoArticle.UpdateArticle(article);
        }
        public bool DeleteArticle(int id)
        {
            return _repoArticle.DeleteArticle(id);
        }
        public List<Article> GetArticlesByPriceRange(float minPrice, float maxPrice)
        {
            var article = _repoArticle.GetArticles();
            return article.Where(a => a.SellingPrice >= minPrice && a.SellingPrice <= maxPrice).ToList();
        }
        public bool IsArticleInStock(int id)
        {
            var article = _repoArticle.GetArticleById(id);
            // Assuming `StockQuantity` is a property of Article
            return article != null && article.StockQuantity > 0;
        }
    }
}
