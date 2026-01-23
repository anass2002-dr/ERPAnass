using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class BillOfMaterials : BaseEntity
    {
        [Key]
        public int idBOM { get; set; }
        public int ParentArticleId { get; set; }
        public int ChildArticleId { get; set; }
        public float QuantityNeeded { get; set; }

        [JsonIgnore]
        public Article? ParentArticle { get; set; }
        [JsonIgnore]
        public Article? ChildArticle { get; set; }
    }
}
