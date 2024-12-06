using ERP_Anass_backend.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class PurchaseDtos
    {
        [DefaultValue(0)]
        public int IdPurchase { get; set; }
        [DefaultValue(null)]
        public string PurchaseRef { get; set; }
        [DefaultValue(-1)]
        public decimal TotalAmount { get; set; } 
        [DefaultValue(0)]
        public int IdCurrency { get; set; }
        [DefaultValue(null)]
        public string PaymentStatus { get; set; }
        [DefaultValue(typeof(DateTime), "")]
        public DateTime PaymentDate { get; set; } = DateTime.Today;
        [DefaultValue(typeof(DateTime), "")]
        public DateTime PurchaseDate { get; set; } = DateTime.Today;
        [DefaultValue(null)]
        public string Remarks { get; set; }
        [DefaultValue(0)]
        public int idSupplier { get; set; }
        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }

        public PurchaseDtos(Purchase purchase)
        {
            this.IdPurchase = purchase.IdPurchase;
            this.PurchaseRef = purchase.PurchaseRef;
            this.TotalAmount = purchase.TotalAmount;
            this.IdCurrency = purchase.IdCurrency;
            this.PaymentStatus = purchase.PaymentStatus;
            this.PurchaseDate = purchase.PurchaseDate;
            this.PaymentDate = purchase.PaymentDate;
            this.Remarks = purchase.Remarks;
            this.idSupplier = purchase.idSupplier;
            this.IsAcitve = purchase.IsAcitve;
        }
        public PurchaseDtos()
        {

        }

    }
}
