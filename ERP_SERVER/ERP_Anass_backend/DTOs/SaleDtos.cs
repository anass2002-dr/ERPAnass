using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class SaleDtos
    {
        [DefaultValue(0)]
        public int IdSale { get; set; }

        [DefaultValue(null)]
        public string SaleRef { get; set; }

        [DefaultValue(0)]
        public decimal? TotalAmount { get; set; }

        [DefaultValue(0)]
        public int? IdCurrency { get; set; }

        [DefaultValue(null)]
        public string? PaymentStatus { get; set; }

        [DefaultValue(null)]
        public DateTime? PaymentDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public DateTime? SaleDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string? Remarks { get; set; }

        [DefaultValue(0)]
        public int? IdCustomer { get; set; }

        [DefaultValue(true)]
        public bool? IsActive { get; set; }

        // Additional Fields
        [DefaultValue(null)]
        public string? SaleStatus { get; set; } // e.g., "Pending", "Approved", "Received"

        [DefaultValue(null)]
        public DateTime? ExpectedDeliveryDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public DateTime? ActualDeliveryDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string? ShippingAddress { get; set; }

        [DefaultValue(null)]
        public string? SaleType { get; set; } // e.g., "Raw Material", "Services"

        [DefaultValue(0)]
        public decimal? DiscountAmount { get; set; }

        [DefaultValue(0)]
        public decimal? DiscountPercentage { get; set; }

        [DefaultValue(0)]
        public decimal? TaxRate { get; set; }

        [DefaultValue(0)]
        public decimal? TotalTaxAmount { get; set; }
        [DefaultValue(0)]
        public decimal? ShippingAmount { get; set; }

        [DefaultValue(0)]
        public decimal? TotalPayment { get; set; }

        [DefaultValue(1)]
        public decimal? ExchangeRate { get; set; } = 1; // Default to 1 for base currency

        [DefaultValue(null)]
        public string? ApprovedBy { get; set; }

        [DefaultValue(null)]
        public DateTime? ApprovalDate { get; set; } // Nullable for optional dates

        [DefaultValue(null)]
        public string? PaymentTerms { get; set; } // e.g., "Net 30", "Net 60"

        [DefaultValue(null)]
        public string? SaleChannel { get; set; } // e.g., "Online", "Offline"

        // Constructor to map from Sale model
        public SaleDtos(Sale purchase)
        {
            IdSale = purchase.IdSale;
            SaleRef = purchase.SaleRef;
            TotalAmount = purchase.TotalAmount;
            TotalPayment = purchase.TotalPayment;
            IdCurrency = purchase.IdCurrency;
            PaymentStatus = purchase.PaymentStatus;
            PaymentDate = purchase.PaymentDate;
            SaleDate = purchase.SaleDate;
            Remarks = purchase.Remarks;
            IdCustomer = purchase.IdCustomer;
            IsActive = purchase.IsActive;

            // Map additional fields if they exist in the Sale model
            SaleStatus = purchase.SaleStatus;
            ExpectedDeliveryDate = purchase.ExpectedDeliveryDate;
            ActualDeliveryDate = purchase.ActualDeliveryDate;
            ShippingAddress = purchase.ShippingAddress;
            SaleType = purchase.SaleType;
            DiscountAmount = purchase.DiscountAmount;
            DiscountPercentage = purchase.DiscountPercentage;
            TaxRate = purchase.TaxRate;
            TotalTaxAmount = purchase.TotalTaxAmount;
            ShippingAmount = purchase.ShippingAmount;
            ExchangeRate = purchase.ExchangeRate;
            ApprovedBy = purchase.ApprovedBy;
            ApprovalDate = purchase.ApprovalDate;
            PaymentTerms = purchase.PaymentTerms;
            SaleChannel = purchase.SaleChannel;
        }

        // Default constructor
        public SaleDtos()
        {
            // Initialize default values
            //TotalAmount = 0;
            //DiscountAmount = 0;
            //DiscountPercentage = 0;
            //TaxRate = 0;
            //TotalTaxAmount = 0;
            //ExchangeRate = 1;
            //IsActive = true;
        }
    }
}
