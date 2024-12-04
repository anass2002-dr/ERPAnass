using ERP_Anass_backend.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class PurchaseDetailsDtos
    {
        [DefaultValue(0)]
        public int IdPurchaseDetails { get; set; }
        [DefaultValue(0)]
        public int idArticle { get; set; }

        [DefaultValue(0)]
        public decimal Quantity { get; set; }
        [DefaultValue(0)]
        public decimal TotalPrice { get; set; }
        [DefaultValue(0)]
        public decimal TaxAmount { get; set; }
        [DefaultValue(null)]
        public string Quality { get; set; }
        [DefaultValue(true)]
        public Boolean IsActive { get; set; }
        [DefaultValue(0)]
        public int IdPurchase { get; set; }


        public PurchaseDetailsDtos(PurchaseDetails purchaseDetails)
        {
            this.IdPurchaseDetails = purchaseDetails.IdPurchaseDetails;
            this.idArticle = purchaseDetails.idArticle;
            this.Quantity = purchaseDetails.Quantity;
            this.TotalPrice = purchaseDetails.TotalPrice;
            this.TaxAmount = purchaseDetails.TaxAmount;
            this.Quality = purchaseDetails.Quality;
            this.IsActive = purchaseDetails.IsActive;
            this.IdPurchase = purchaseDetails.IdPurchase;
        }

        public PurchaseDetailsDtos() { }
    }
}
