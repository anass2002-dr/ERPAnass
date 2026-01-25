using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Purchase : BaseEntity
    {
        [Key]
        public int IdPurchase { get; set; } // Renamed from IdPurchase
        public string PurchaseRef { get; set; }

        public decimal? TotalAmount { get; set; }
        public decimal? TotalPayment { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        // CreatedAt, UpdatedAt, IsActive removed -> Inherited from BaseEntity
        public string? Remarks { get; set; }

        public int? idSupplier { get; set; }
        [JsonIgnore]
        public Supplier? Supplier { get; set; }

        public int? IdCurrency { get; set; }
        [JsonIgnore]
        public Currency? Currencyobj { get; set; }

        // Logistics
        public int? idWarehouse { get; set; }
        [JsonIgnore]
        public Warehouse? Warehouse { get; set; }

        public int? idEmployee { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; }

        // Finance
        public int? idInvoice { get; set; } // Link to AP Invoice
        [JsonIgnore]
        public Invoice? Invoice { get; set; }

        public int? idAccount { get; set; } // Expense/Asset Account (GL)
        [JsonIgnore]
        public Account? Account { get; set; }


        public string PurchaseStatus { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PurchaseType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal? ShippingAmount { get; set; }
        public decimal? ExchangeRate { get; set; }
        
        // ApprovedBy replaced by idEmployee relationship, but keeping for backward compat if needed or legacy data
        public string? ApprovedBy { get; set; } 
        public DateTime? ApprovalDate { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PurchaseChannel { get; set; }

        [JsonIgnore]
        public ICollection<PurchaseDetails> PurchaseDetails { get; set; } = [];
    }
}
