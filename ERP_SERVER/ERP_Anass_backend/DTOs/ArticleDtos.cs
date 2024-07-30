using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.DTOs
{
    public class ArticleDtos
    {
        public int idArticle { get; set; }
        public string ArticleRef { get; set; }
        public string ArticleName { get; set; } = "";
        public string DescriptionArticle { get; set; } = "";
        public float PurchasePrice { get; set; } = 0;
        public float SellingPrice { get; set; }  = 0;

        public int FamilyID { get; set; } 
     
        public int StockQuantity { get; set; } = 0;
        public ArticleDtos(Article article)
        {
            //this.idArticle = article.idArticle;
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
