namespace ERP_Anass_backend.DTOs
{
    public class InvoicePdfDto
    {
        public int idInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string Status { get; set; }
        public string InvoiceType { get; set; }

        // Sender Info (Tenant)
        public TenantDtos Tenant { get; set; }

        // Receiver Info (Customer or Supplier)
        public CustomerDtos? Customer { get; set; }
        public SupplierDtos? Supplier { get; set; }

        public List<InvoiceDetailPdfDto> InvoiceDetails { get; set; }
    }

    public class InvoiceDetailPdfDto
    {
        public int idInvoiceDetail { get; set; }
        public string ItemName { get; set; } // Article Name
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
    }
}
