using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class InvoiceDetails : BaseEntity
    {
        [Key]
        public int idInvoiceDetail { get; set; }
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }

        public int InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        [JsonIgnore]
        public Invoice Invoice { get; set; }

        public int? ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        [JsonIgnore]
        public Article? Article { get; set; }
    }
}
