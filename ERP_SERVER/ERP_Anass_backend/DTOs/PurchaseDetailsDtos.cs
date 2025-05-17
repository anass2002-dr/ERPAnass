using ERP_Anass_backend.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class PurchaseDetailsDtos
    {
        [DefaultValue(0)]
        public int IdPurchaseDetails { get; set; }

        [DefaultValue(0)]
        public int? idArticle { get; set; }

        [DefaultValue(0)]
        public decimal? Quantity { get; set; }

        [DefaultValue(0)]
        public decimal? UnitPrice { get; set; } // Added UnitPrice for clarity

        [DefaultValue(0)]
        public decimal? TotalPrice { get; set; }

        [DefaultValue(0)]
        public decimal? TaxAmount { get; set; }

        [DefaultValue(null)]
        public string? Quality { get; set; }

        [DefaultValue(true)]
        public bool? IsActive { get; set; }

        [DefaultValue(0)]
        public int? IdPurchase { get; set; }

        // Additional Fields
        [DefaultValue(null)]
        public string? LineItemStatus { get; set; } // e.g., "Pending", "Received", "Cancelled"

        [DefaultValue(null)]
        public string? UnitOfMeasure { get; set; } // e.g., "Pieces", "Kilograms", "Liters"

        [DefaultValue(0)]
        public decimal? LineDiscountAmount { get; set; } // Discount at the line item level

        [DefaultValue(0)]
        public decimal? LineDiscountPercentage { get; set; } // Discount percentage at the line item level

        [DefaultValue(null)]
        public string? BatchNumber { get; set; } // For batch/lot tracking

        [DefaultValue(null)]
        public DateTime? ExpiryDate { get; set; } // For perishable items

        [DefaultValue(null)]
        public string? SerialNumber { get; set; } // For serialized items

        [DefaultValue(null)]
        public string? WarehouseLocation { get; set; } // Location where the item will be stored

        [DefaultValue(0)]
        public decimal? ReceivedQuantity { get; set; } // Quantity received against ordered quantity

        [DefaultValue(0)]
        public decimal? RejectedQuantity { get; set; } // Quantity rejected during quality inspection

        [DefaultValue(0)]
        public decimal? LineTaxRate { get; set; } // Tax rate specific to the line item

        // Constructor to map from PurchaseDetails model
        public PurchaseDetailsDtos(PurchaseDetails purchaseDetails)
        {
            IdPurchaseDetails = purchaseDetails.IdPurchaseDetails;
            idArticle = purchaseDetails.idArticle;
            Quantity = purchaseDetails.Quantity;
            UnitPrice = purchaseDetails.UnitPrice; // Ensure this is mapped from the model
            TotalPrice = purchaseDetails.TotalPrice;
            TaxAmount = purchaseDetails.TaxAmount;
            Quality = purchaseDetails.Quality;
            IsActive = purchaseDetails.IsActive;
            IdPurchase = purchaseDetails.IdPurchase;

            // Map additional fields if they exist in the PurchaseDetails model
            LineItemStatus = purchaseDetails.LineItemStatus;
            UnitOfMeasure = purchaseDetails.UnitOfMeasure;
            LineDiscountAmount = purchaseDetails.LineDiscountAmount;
            LineDiscountPercentage = purchaseDetails.LineDiscountPercentage;
            BatchNumber = purchaseDetails.BatchNumber;
            ExpiryDate = purchaseDetails.ExpiryDate;
            SerialNumber = purchaseDetails.SerialNumber;
            WarehouseLocation = purchaseDetails.WarehouseLocation;
            ReceivedQuantity = purchaseDetails.ReceivedQuantity;
            RejectedQuantity = purchaseDetails.RejectedQuantity;
            LineTaxRate = purchaseDetails.LineTaxRate;
        }

        // Default constructor
        public PurchaseDetailsDtos()
        {
            // Initialize default values
            //Quantity = 0;
            //UnitPrice = 0;
            //TotalPrice = 0;
            //TaxAmount = 0;
            //LineDiscountAmount = 0;
            //LineDiscountPercentage = 0;
            //ReceivedQuantity = 0;
            //RejectedQuantity = 0;
            //LineTaxRate = 0;
            //IsActive = true;
        }
    }
}