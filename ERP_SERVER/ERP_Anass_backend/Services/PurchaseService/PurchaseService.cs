using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.SaleRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Services.SaleService
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepo _purchaseRepo;
        private readonly ILogger<SaleService> _logger;

        public SaleService(ISaleRepo purchaseRepo, ILogger<SaleService> logger)
        {
            _purchaseRepo = purchaseRepo;
            _logger = logger;
        }

        public Sale AddSale(SaleDtos purchaseDtos)
        {
            try
            {
                // Validate DTO
                if (purchaseDtos == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDtos), "Sale DTO cannot be null.");
                }

                // Map DTO to Model
                var purchase = new Sale
                {
                    SaleRef = purchaseDtos.SaleRef,
                    TotalAmount = purchaseDtos.TotalAmount,
                    TotalPayment = purchaseDtos.TotalPayment,
                    IdCurrency = purchaseDtos.IdCurrency,
                    PaymentStatus = purchaseDtos.PaymentStatus,
                    PaymentDate = purchaseDtos.PaymentDate,
                    SaleDate = purchaseDtos.SaleDate,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Remarks = purchaseDtos.Remarks,
                    IdCustomer = purchaseDtos.IdCustomer,
                    IsActive = purchaseDtos.IsActive,

                    // Map additional fields
                    SaleStatus = purchaseDtos.SaleStatus,
                    ExpectedDeliveryDate = purchaseDtos.ExpectedDeliveryDate,
                    ActualDeliveryDate = purchaseDtos.ActualDeliveryDate,
                    ShippingAddress = purchaseDtos.ShippingAddress,
                    SaleType = purchaseDtos.SaleType,
                    DiscountAmount = purchaseDtos.DiscountAmount,
                    DiscountPercentage = purchaseDtos.DiscountPercentage,
                    TaxRate = purchaseDtos.TaxRate,
                    TotalTaxAmount = purchaseDtos.TotalTaxAmount,
                    ExchangeRate = purchaseDtos.ExchangeRate,
                    ApprovedBy = purchaseDtos.ApprovedBy,
                    ApprovalDate = purchaseDtos.ApprovalDate,
                    PaymentTerms = purchaseDtos.PaymentTerms,
                    SaleChannel = purchaseDtos.SaleChannel
                };

                var addedSale = _purchaseRepo.AddSale(purchase);
                _logger.LogInformation("Sale added successfully with ID: {IdSale}", addedSale.IdSale);
                return addedSale;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding a purchase.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeleteSale(int id)
        {
            try
            {
                bool isDeleted = _purchaseRepo.DeleteSale(id);
                if (isDeleted)
                {
                    _logger.LogInformation("Sale with ID: {IdSale} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found for deletion.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale GetSaleById(int id)
        {
            try
            {
                var purchase = _purchaseRepo.GetSaleById(id);
                if (purchase == null)
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found.", id);
                }
                return purchase;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetSaleDetails()
        {
            try
            {
                var purchaseDetails = _purchaseRepo.GetSaleDetails();
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<Sale> GetSales()
        {
            try
            {
                var purchases = _purchaseRepo.GetSales();
                return purchases;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchases.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale UpdateSale(int id, SaleDtos purchaseDtos)
        {
            try
            {
                var existingSale = _purchaseRepo.GetSaleById(id);
                if (existingSale == null)
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found for update.", id);
                    throw new KeyNotFoundException($"Sale with ID {id} not found.");
                }

                // Update fields if provided in DTO
                existingSale.SaleRef = purchaseDtos.SaleRef ?? existingSale.SaleRef;
                existingSale.TotalAmount = purchaseDtos.TotalAmount != -1 ? purchaseDtos.TotalAmount : existingSale.TotalAmount;
                existingSale.TotalPayment = purchaseDtos.TotalPayment != -1 ? purchaseDtos.TotalPayment : existingSale.TotalPayment;
                existingSale.IdCurrency = purchaseDtos.IdCurrency != 0 ? purchaseDtos.IdCurrency : existingSale.IdCurrency;
                existingSale.PaymentStatus = purchaseDtos.PaymentStatus ?? existingSale.PaymentStatus;
                existingSale.PaymentDate = purchaseDtos.PaymentDate ?? existingSale.PaymentDate;
                existingSale.SaleDate = purchaseDtos.SaleDate ?? existingSale.SaleDate;
                existingSale.Remarks = purchaseDtos.Remarks ?? existingSale.Remarks;
                existingSale.IdCustomer = purchaseDtos.IdCustomer != 0 ? purchaseDtos.IdCustomer : existingSale.IdCustomer;
                existingSale.IsActive = purchaseDtos.IsActive;
                existingSale.UpdatedAt = DateTime.UtcNow;

                // Update additional fields
                existingSale.SaleStatus = purchaseDtos.SaleStatus ?? existingSale.SaleStatus;
                existingSale.ExpectedDeliveryDate = purchaseDtos.ExpectedDeliveryDate ?? existingSale.ExpectedDeliveryDate;
                existingSale.ActualDeliveryDate = purchaseDtos.ActualDeliveryDate ?? existingSale.ActualDeliveryDate;
                existingSale.ShippingAddress = purchaseDtos.ShippingAddress ?? existingSale.ShippingAddress;
                existingSale.SaleType = purchaseDtos.SaleType ?? existingSale.SaleType;
                existingSale.DiscountAmount = purchaseDtos.DiscountAmount;
                existingSale.DiscountPercentage = purchaseDtos.DiscountPercentage;
                existingSale.TaxRate = purchaseDtos.TaxRate;
                existingSale.TotalTaxAmount = purchaseDtos.TotalTaxAmount;
                existingSale.ExchangeRate = purchaseDtos.ExchangeRate;
                existingSale.ApprovedBy = purchaseDtos.ApprovedBy ?? existingSale.ApprovedBy;
                existingSale.ApprovalDate = purchaseDtos.ApprovalDate ?? existingSale.ApprovalDate;
                existingSale.PaymentTerms = purchaseDtos.PaymentTerms ?? existingSale.PaymentTerms;
                existingSale.SaleChannel = purchaseDtos.SaleChannel ?? existingSale.SaleChannel;

                var updatedSale = _purchaseRepo.UpdateSale(id, existingSale);
                _logger.LogInformation("Sale with ID: {IdSale} updated successfully.", id);
                return updatedSale;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase with ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale checkRef(string reff)
        {
            try
            {
                if (string.IsNullOrEmpty(reff))
                {
                    _logger.LogWarning("Reference string is null or empty.");
                    return null;
                }

                var purchases = GetSales();
                foreach (var purchase in purchases)
                {
                    if (purchase.SaleRef == reff)
                    {
                        _logger.LogInformation("Sale with refrence {reff} found.", reff);
                        return purchase;
                    }
                }

                _logger.LogWarning("Sale with refrence {reff} not found.", reff);
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while checking purchase refrence: {reff}.", reff);
                throw; // Re-throw the exception for handling at a higher level
            }
        }
    }
}