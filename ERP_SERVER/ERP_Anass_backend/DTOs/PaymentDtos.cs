using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class PaymentDtos
    {
        public int idPayment { get; set; }
        [DefaultValue(0)]
        public float Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        [DefaultValue(null)]
        public string PaymentMethod { get; set; }
        [DefaultValue(null)]
        public string ReferenceNumber { get; set; }
        [DefaultValue(null)]
        public int? SaleId { get; set; }
        [DefaultValue(null)]
        public int? PurchaseId { get; set; }

        public PaymentDtos(Payment payment)
        {
            this.idPayment = payment.idPayment;
            this.Amount = payment.Amount;
            this.PaymentDate = payment.PaymentDate;
            this.PaymentMethod = payment.PaymentMethod;
            this.ReferenceNumber = payment.ReferenceNumber;
            this.SaleId = payment.SaleId;
            this.PurchaseId = payment.PurchaseId;
            this.idBankAccount = payment.idBankAccount;
            this.InvoiceId = payment.InvoiceId;
        }

        public int? idBankAccount { get; set; }
        public int? InvoiceId { get; set; }

        public PaymentDtos() { }
    }
}
