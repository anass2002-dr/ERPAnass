using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Invoice : BaseEntity
    {
        [Key]
        public int idInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string Status { get; set; } // Draft, Open, Paid, Overdue
        public string InvoiceType { get; set; } // Sale, Purchase

        // Relationships
        public int? SaleId { get; set; }
        [ForeignKey("SaleId")]
        [JsonIgnore]
        public Sale? Sale { get; set; }

        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [JsonIgnore]
        public Customer? Customer { get; set; }

        public int? PurchaseId { get; set; }
        [ForeignKey("PurchaseId")]
        [JsonIgnore]
        public Purchase? Purchase { get; set; }

        public int? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        [JsonIgnore]
        public Supplier? Supplier { get; set; }

        [JsonIgnore]
        public ICollection<InvoiceDetails> InvoiceDetails { get; set; } = new List<InvoiceDetails>();
    }
}
