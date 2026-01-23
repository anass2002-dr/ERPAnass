using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.PurchaseRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepo _purchaseRepo;
        private readonly ILogger<PurchaseService> _logger;

        public PurchaseService(IPurchaseRepo purchaseRepo, ILogger<PurchaseService> logger)
        {
            _purchaseRepo = purchaseRepo;
            _logger = logger;
        }

        public Purchase AddPurchase(PurchaseDtos purchaseDtos)
        {
            try
            {
                // Validate DTO
                if (purchaseDtos == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDtos), "Purchase DTO cannot be null.");
                }

                // Map DTO to Model
                var purchase = new Purchase
                {
                    PurchaseRef = purchaseDtos.PurchaseRef,
                    TotalAmount = purchaseDtos.TotalAmount,
                    TotalPayment = purchaseDtos.TotalPayment,
                    IdCurrency = purchaseDtos.IdCurrency,
                    PaymentStatus = purchaseDtos.PaymentStatus,
                    PaymentDate = purchaseDtos.PaymentDate,
                    PurchaseDate = purchaseDtos.PurchaseDate,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Remarks = purchaseDtos.Remarks,
                    idSupplier = purchaseDtos.idSupplier,
                    IsActive = purchaseDtos.IsActive,

                    // Map additional fields
                    PurchaseStatus = purchaseDtos.PurchaseStatus,
                    ExpectedDeliveryDate = purchaseDtos.ExpectedDeliveryDate,
                    ActualDeliveryDate = purchaseDtos.ActualDeliveryDate,
                    ShippingAddress = purchaseDtos.ShippingAddress,
                    PurchaseType = purchaseDtos.PurchaseType,
                    DiscountAmount = purchaseDtos.DiscountAmount,
                    DiscountPercentage = purchaseDtos.DiscountPercentage,
                    TaxRate = purchaseDtos.TaxRate,
                    TotalTaxAmount = purchaseDtos.TotalTaxAmount,
                    ShippingAmount = purchaseDtos.ShippingAmount,
                    ExchangeRate = purchaseDtos.ExchangeRate,
                    ApprovedBy = purchaseDtos.ApprovedBy,
                    ApprovalDate = purchaseDtos.ApprovalDate,
                    PaymentTerms = purchaseDtos.PaymentTerms,
                    PurchaseChannel = purchaseDtos.PurchaseChannel
                };

                var addedPurchase = _purchaseRepo.AddPurchase(purchase);
                _logger.LogInformation("Purchase added successfully with ID: {IdPurchase}", addedPurchase.IdPurchase);
                return addedPurchase;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding a purchase.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeletePurchase(int id)
        {
            try
            {
                bool isDeleted = _purchaseRepo.DeletePurchase(id);
                if (isDeleted)
                {
                    _logger.LogInformation("Purchase with ID: {IdPurchase} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("Purchase with ID: {IdPurchase} not found for deletion.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase with ID: {IdPurchase}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Purchase GetPurchaseById(int id)
        {
            try
            {
                var purchase = _purchaseRepo.GetPurchaseById(id);
                if (purchase == null)
                {
                    _logger.LogWarning("Purchase with ID: {IdPurchase} not found.", id);
                }
                return purchase;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase with ID: {IdPurchase}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetPurchaseDetails()
        {
            try
            {
                var purchaseDetails = _purchaseRepo.GetPurchaseDetails();
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<Purchase> GetPurchases()
        {
            try
            {
                var purchases = _purchaseRepo.GetPurchases();
                return purchases;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchases.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Purchase UpdatePurchase(int id, PurchaseDtos purchaseDtos)
        {
            try
            {
                var existingPurchase = _purchaseRepo.GetPurchaseById(id);
                if (existingPurchase == null)
                {
                    _logger.LogWarning("Purchase with ID: {IdPurchase} not found for update.", id);
                    throw new KeyNotFoundException($"Purchase with ID {id} not found.");
                }
                if (purchaseDtos.PurchaseStatus == "Received" && existingPurchase.PurchaseStatus != "Received")
                {
                    RecivedPurchase(id, true);
                }
                else if (purchaseDtos.PurchaseStatus != "Received" && existingPurchase.PurchaseStatus == "Received")
                {
                    RecivedPurchase(id, false);
                }

                // Update fields if provided in DTO
                existingPurchase.PurchaseRef = purchaseDtos.PurchaseRef ?? existingPurchase.PurchaseRef;
                existingPurchase.TotalAmount = purchaseDtos.TotalAmount != -1 ? purchaseDtos.TotalAmount : existingPurchase.TotalAmount;
                existingPurchase.TotalPayment = purchaseDtos.TotalPayment != -1 ? purchaseDtos.TotalPayment : existingPurchase.TotalPayment;
                existingPurchase.IdCurrency = purchaseDtos.IdCurrency != 0 ? purchaseDtos.IdCurrency : existingPurchase.IdCurrency;
                existingPurchase.PaymentStatus = purchaseDtos.PaymentStatus ?? existingPurchase.PaymentStatus;
                existingPurchase.PaymentDate = purchaseDtos.PaymentDate ?? existingPurchase.PaymentDate;
                existingPurchase.PurchaseDate = purchaseDtos.PurchaseDate ?? existingPurchase.PurchaseDate;
                existingPurchase.Remarks = purchaseDtos.Remarks ?? existingPurchase.Remarks;
                existingPurchase.idSupplier = purchaseDtos.idSupplier != 0 ? purchaseDtos.idSupplier : existingPurchase.idSupplier;
                existingPurchase.IsActive = purchaseDtos.IsActive;
                existingPurchase.UpdatedAt = DateTime.UtcNow;

                // Update additional fields
                existingPurchase.PurchaseStatus = purchaseDtos.PurchaseStatus ?? existingPurchase.PurchaseStatus;
                existingPurchase.ExpectedDeliveryDate = purchaseDtos.ExpectedDeliveryDate ?? existingPurchase.ExpectedDeliveryDate;
                existingPurchase.ActualDeliveryDate = purchaseDtos.ActualDeliveryDate ?? existingPurchase.ActualDeliveryDate;
                existingPurchase.ShippingAddress = purchaseDtos.ShippingAddress ?? existingPurchase.ShippingAddress;
                existingPurchase.PurchaseType = purchaseDtos.PurchaseType ?? existingPurchase.PurchaseType;
                existingPurchase.DiscountAmount = purchaseDtos.DiscountAmount;
                existingPurchase.DiscountPercentage = purchaseDtos.DiscountPercentage;
                existingPurchase.TaxRate = purchaseDtos.TaxRate;
                existingPurchase.TotalTaxAmount = purchaseDtos.TotalTaxAmount;
                existingPurchase.ShippingAmount = purchaseDtos.ShippingAmount;
                existingPurchase.ExchangeRate = purchaseDtos.ExchangeRate;
                existingPurchase.ApprovedBy = purchaseDtos.ApprovedBy ?? existingPurchase.ApprovedBy;
                existingPurchase.ApprovalDate = purchaseDtos.ApprovalDate ?? existingPurchase.ApprovalDate;
                existingPurchase.PaymentTerms = purchaseDtos.PaymentTerms ?? existingPurchase.PaymentTerms;
                existingPurchase.PurchaseChannel = purchaseDtos.PurchaseChannel ?? existingPurchase.PurchaseChannel;

                var updatedPurchase = _purchaseRepo.UpdatePurchase(id, existingPurchase);
                _logger.LogInformation("Purchase with ID: {IdPurchase} updated successfully.", id);
                return updatedPurchase;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase with ID: {IdPurchase}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Purchase checkRef(string reff)
        {
            try
            {
                if (string.IsNullOrEmpty(reff))
                {
                    _logger.LogWarning("Reference string is null or empty.");
                    return null;
                }

                var purchases = GetPurchases();
                foreach (var purchase in purchases)
                {
                    if (purchase.PurchaseRef == reff)
                    {
                        _logger.LogInformation("Purchase with refrence {reff} found.", reff);
                        return purchase;
                    }
                }

                _logger.LogWarning("Purchase with refrence {reff} not found.", reff);
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while checking purchase refrence: {reff}.", reff);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<PurchaseDetails> RecivedPurchase(int id, Boolean recived)
        {
            return _purchaseRepo.RecivedPurchase(id, recived);
        }
    }
}