using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class ArticleDtos
    {
        public int idArticle { get; set; }
        [DefaultValue(null)]
        public string ArticleRef { get; set; }
        [DefaultValue(null)]
        public string ArticleName { get; set; }
        [DefaultValue(null)]
        public string DescriptionArticle { get; set; }
        [DefaultValue(0)]
        public float PurchasePrice { get; set; } 
        [DefaultValue(0)]
        public float SellingPrice { get; set; }
        [DefaultValue(null)]
        public int FamilyID { get; set; }    
        [DefaultValue(0)]
        public int StockQuantity { get; set; }
        public ArticleDtos(Article article)
        {
            this.idArticle = article.idArticle;
            this.ArticleRef = article.ArticleRef;   
            this.ArticleName = article.ArticleName;
            this.DescriptionArticle = article.DescriptionArticle;
            this.PurchasePrice = article.PurchasePrice;
            this.SellingPrice=article.SellingPrice;
            this.FamilyID=article.FamilyID;
            this.StockQuantity=article.StockQuantity;
        }
        public ArticleDtos() { }
    }

}
