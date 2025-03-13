using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Article
    {
        [Key]
        public int idArticle { get; set; }
        public string ArticleRef { get; set; }
        public string ArticleName { get; set; }
        public string DescriptionArticle { get; set; }
        public float PurchasePrice { get; set; }
        public float SellingPrice { get; set; }

        public Boolean IsAcitve { get; set; }
        public int? FamilyID { get; set; }
        [JsonIgnore]
        public Familly? Familly { get; set; }
        // Nullable Foreign Key
        public int? BrandID { get; set; }

        // Navigation Property (Optional)
        public Brand? Brand { get; set; }
        public int StockQuantity { get; set; }

        [JsonIgnore]
        public ICollection<PurchaseDetails> PurchaseDetails { get; set; } = [];
    }
}
