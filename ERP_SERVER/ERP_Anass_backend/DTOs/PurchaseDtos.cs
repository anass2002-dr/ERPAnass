using ERP_Anass_backend.Models;
using System;
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

        [DefaultValue(0)]
        public decimal TotalAmount { get; set; }

        [DefaultValue(0)]
        public int? IdCurrency { get; set; }

        [DefaultValue(null)]
        public string PaymentStatus { get; set; }

        [DefaultValue(null)]
        public DateTime? PaymentDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public DateTime? PurchaseDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string Remarks { get; set; }

        [DefaultValue(0)]
        public int? idSupplier { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        // Additional Fields
        [DefaultValue(null)]
        public string PurchaseStatus { get; set; } // e.g., "Pending", "Approved", "Received"

        [DefaultValue(null)]
        public DateTime? ExpectedDeliveryDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public DateTime? ActualDeliveryDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string ShippingAddress { get; set; }

        [DefaultValue(null)]
        public string PurchaseType { get; set; } // e.g., "Raw Material", "Services"

        [DefaultValue(0)]
        public decimal DiscountAmount { get; set; }

        [DefaultValue(0)]
        public decimal DiscountPercentage { get; set; }

        [DefaultValue(0)]
        public decimal TaxRate { get; set; }

        [DefaultValue(0)]
        public decimal TotalTaxAmount { get; set; }

        [DefaultValue(1)]
        public decimal ExchangeRate { get; set; } = 1; // Default to 1 for base currency

        [DefaultValue(null)]
        public string ApprovedBy { get; set; }

        [DefaultValue(null)]
        public DateTime? ApprovalDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string PaymentTerms { get; set; } // e.g., "Net 30", "Net 60"

        [DefaultValue(null)]
        public string PurchaseChannel { get; set; } // e.g., "Online", "Offline"

        // Constructor to map from Purchase model
        public PurchaseDtos(Purchase purchase)
        {
            IdPurchase = purchase.IdPurchase;
            PurchaseRef = purchase.PurchaseRef;
            TotalAmount = purchase.TotalAmount;
            IdCurrency = purchase.IdCurrency;
            PaymentStatus = purchase.PaymentStatus;
            PaymentDate = purchase.PaymentDate;
            PurchaseDate = purchase.PurchaseDate;
            Remarks = purchase.Remarks;
            idSupplier = purchase.idSupplier;
            IsActive = purchase.IsActive;

            // Map additional fields if they exist in the Purchase model
            PurchaseStatus = purchase.PurchaseStatus;
            ExpectedDeliveryDate = purchase.ExpectedDeliveryDate;
            ActualDeliveryDate = purchase.ActualDeliveryDate;
            ShippingAddress = purchase.ShippingAddress;
            PurchaseType = purchase.PurchaseType;
            DiscountAmount = purchase.DiscountAmount;
            DiscountPercentage = purchase.DiscountPercentage;
            TaxRate = purchase.TaxRate;
            TotalTaxAmount = purchase.TotalTaxAmount;
            ExchangeRate = purchase.ExchangeRate;
            ApprovedBy = purchase.ApprovedBy;
            ApprovalDate = purchase.ApprovalDate;
            PaymentTerms = purchase.PaymentTerms;
            PurchaseChannel = purchase.PurchaseChannel;
        }

        // Default constructor
        public PurchaseDtos()
        {
            // Initialize default values
            TotalAmount = 0;
            DiscountAmount = 0;
            DiscountPercentage = 0;
            TaxRate = 0;
            TotalTaxAmount = 0;
            ExchangeRate = 1;
            IsActive = true;
        }
    }
}