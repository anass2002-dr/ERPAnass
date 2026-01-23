using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.DTOs
{
    public class InvoiceDto : BaseEntity
    {
        public int idInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string Status { get; set; }
        public string InvoiceType { get; set; }
        
        public int? SaleId { get; set; }
        public int? CustomerId { get; set; }
        public int? PurchaseId { get; set; }
        public int? SupplierId { get; set; }

        public ICollection<InvoiceDetailDto> InvoiceDetails { get; set; }
    }

    public class InvoiceCreateDto
    {
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string Status { get; set; }
        public string InvoiceType { get; set; }

        public int? SaleId { get; set; }
        public int? CustomerId { get; set; }
        public int? PurchaseId { get; set; }
        public int? SupplierId { get; set; }

        public List<InvoiceDetailCreateDto> InvoiceDetails { get; set; }
    }

    public class InvoiceDetailDto : BaseEntity
    {
        public int idInvoiceDetail { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
        public int InvoiceId { get; set; }
        public int? ArticleId { get; set; }
    }

    public class InvoiceDetailCreateDto
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
        public int? ArticleId { get; set; }
    }
}
