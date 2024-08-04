using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.ArticleRepo
{
    public class RepoArticle : IRepoArticle
    {
        private readonly DbContextERP _context;

        public RepoArticle(DbContextERP context)
        {
            _context = context;
        }

        public Article AddArticle(Article article)
        {
            var ar = _context.Article.Add(article);
            _context.SaveChanges();
            return ar.Entity;
        }

        public bool DeleteArticle(int id)
        {
            var article = _context.Article.Find(id);
            if (article == null)
            {
                return false;
            }

            _context.Article.Remove(article);
            _context.SaveChanges();
            return true;
        }

        public Article GetArticleById(int id)
        {
            return _context.Article.Find(id);
        }

        public List<Article> GetArticles()
        {
            return _context.Article.Include(a => a.Familly).ToList();
        }
        public List<dynamic> GetArticlesDetails()
        {
            var articles = _context.Article
                .Include(a => a.Familly)
                .Select(a => new
                {
                    a.idArticle,
                    a.ArticleRef,
                    a.ArticleName,
                    a.DescriptionArticle,
                    a.PurchasePrice,
                    a.SellingPrice,
                    a.StockQuantity,
                    Family = new
                    {
                        a.Familly.idFamilly,
                        a.Familly.familyRef,
                        a.Familly.familyName,
                        a.Familly.familyDesc
                    }
                })
                .ToList<dynamic>();

            return articles;
        }
        public Article UpdateArticle(Article article)
        {
            var existingArticle = _context.Article.Find(article.idArticle);

            existingArticle.ArticleRef = article.ArticleRef != null ? article.ArticleRef : existingArticle.ArticleRef;
            existingArticle.ArticleName = article.ArticleName != null ? article.ArticleName : existingArticle.ArticleName;
            existingArticle.DescriptionArticle = article.DescriptionArticle != null ? article.DescriptionArticle : existingArticle.DescriptionArticle;
            existingArticle.PurchasePrice = article.PurchasePrice != 0 ? article.PurchasePrice : existingArticle.PurchasePrice;
            existingArticle.SellingPrice = article.SellingPrice != 0 ? article.SellingPrice : existingArticle.SellingPrice;
            existingArticle.FamilyID = article.FamilyID!= 0 ? article.FamilyID : existingArticle.FamilyID;
            //existingArticle.Familly = article.Familly;
            existingArticle.StockQuantity = article.StockQuantity!= 0 ? article.StockQuantity : existingArticle.StockQuantity;

            _context.SaveChanges();
            return _context.Article.Find(article.idArticle);
        }
    }
}
