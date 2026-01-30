using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.PurchaseRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public class PurchaseDetailsService : IPurchaseDetailsService
    {
        private readonly IPurchaseDetailsRepo _purchaseDetailsRepo;
        private readonly ILogger<PurchaseDetailsService> _logger;

        public PurchaseDetailsService(IPurchaseDetailsRepo purchaseDetailsRepo, ILogger<PurchaseDetailsService> logger)
        {
            _purchaseDetailsRepo = purchaseDetailsRepo;
            _logger = logger;
        }

        public PurchaseDetails AddPurchasesDetails(PurchaseDetailsDtos purchaseDtos)
        {
            try
            {
                // Validate DTO
                if (purchaseDtos == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDtos), "PurchaseDetails DTO cannot be null.");
                }

                // Map DTO to Model
                var purchaseDetails = new PurchaseDetails
                {
                    idArticle = purchaseDtos.idArticle,
                    Quantity = purchaseDtos.Quantity,
                    UnitPrice = purchaseDtos.UnitPrice,
                    TotalPrice = purchaseDtos.TotalPrice,
                    TaxAmount = purchaseDtos.TaxAmount,
                    Quality = purchaseDtos.Quality,
                    IsAcitve = purchaseDtos.IsActive ?? true, // DTO probably IsActive, Model IsAcitve
                    IdPurchase = purchaseDtos.IdPurchase,
                    idTaxConfig = purchaseDtos.IdTaxConfig,

                    // Map additional fields
                    LineItemStatus = purchaseDtos.LineItemStatus,
                    UnitOfMeasure = purchaseDtos.UnitOfMeasure,
                    LineDiscountAmount = purchaseDtos.LineDiscountAmount,
                    LineDiscountPercentage = purchaseDtos.LineDiscountPercentage,
                    BatchNumber = purchaseDtos.BatchNumber,
                    ExpiryDate = purchaseDtos.ExpiryDate,
                    SerialNumber = purchaseDtos.SerialNumber,
                    WarehouseLocation = purchaseDtos.WarehouseLocation,
                    ReceivedQuantity = purchaseDtos.ReceivedQuantity,
                    RejectedQuantity = purchaseDtos.RejectedQuantity,
                    LineTaxRate = purchaseDtos.LineTaxRate,
                    ExtraTax = purchaseDtos.ExtraTax
                };

                var addedPurchaseDetails = _purchaseDetailsRepo.AddPurchaseDetails(purchaseDetails);
                _logger.LogInformation("PurchaseDetails added successfully with ID: {IdPurchaseDetails}", addedPurchaseDetails.IdPurchaseDetails);
                return addedPurchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeletePurchasesDetails(int id)
        {
            try
            {
                bool isDeleted = _purchaseDetailsRepo.DeletePurchaseDetails(id);
                if (isDeleted)
                {
                    _logger.LogInformation("PurchaseDetails with ID: {idPurchaseDetails} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("PurchaseDetails with ID: {idPurchaseDetails} not found for deletion.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase details with ID: {idPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetPurchaseDetailsByPurchase(int id)
        {
            try
            {
                var purchaseDetails = _purchaseDetailsRepo.GetPurchaseDetailsByPurchase(id);
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details for purchase ID: {idPurchase}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<PurchaseDetails> GetPurchasesDetails()
        {
            try
            {
                return _purchaseDetailsRepo.GetPurchaseDetails();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public PurchaseDetails GetPurchasesDetailsById(int id)
        {
            try
            {
                var purchaseDetails = _purchaseDetailsRepo.GetPurchaseDetailsById(id);
                if (purchaseDetails == null)
                {
                    _logger.LogWarning("PurchaseDetails with ID: {idPurchaseDetails} not found.", id);
                }
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details with ID: {IdPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public PurchaseDetails UpdatePurchasesDetails(int id, PurchaseDetailsDtos purchaseDtos)
        {
            try
            {
                var existingPurchaseDetails = _purchaseDetailsRepo.GetPurchaseDetailsById(id);
                if (existingPurchaseDetails == null)
                {
                    _logger.LogWarning("PurchaseDetails with ID: {idPurchaseDetails} not found for update.", id);
                    throw new KeyNotFoundException($"PurchaseDetails with ID {id} not found.");
                }

                // Update fields if provided in DTO
                existingPurchaseDetails.Quantity = purchaseDtos.Quantity != 0 ? purchaseDtos.Quantity : existingPurchaseDetails.Quantity;
                existingPurchaseDetails.UnitPrice = purchaseDtos.UnitPrice != 0 ? purchaseDtos.UnitPrice : existingPurchaseDetails.UnitPrice;
                existingPurchaseDetails.TotalPrice = purchaseDtos.TotalPrice != 0 ? purchaseDtos.TotalPrice : existingPurchaseDetails.TotalPrice;
                existingPurchaseDetails.TaxAmount = purchaseDtos.TaxAmount != 0 ? purchaseDtos.TaxAmount : existingPurchaseDetails.TaxAmount;
                existingPurchaseDetails.Quality = purchaseDtos.Quality ?? existingPurchaseDetails.Quality;
                existingPurchaseDetails.IsAcitve = purchaseDtos.IsActive ?? existingPurchaseDetails.IsAcitve;

                // Update additional fields
                existingPurchaseDetails.LineItemStatus = purchaseDtos.LineItemStatus ?? existingPurchaseDetails.LineItemStatus;
                existingPurchaseDetails.UnitOfMeasure = purchaseDtos.UnitOfMeasure ?? existingPurchaseDetails.UnitOfMeasure;
                existingPurchaseDetails.LineDiscountAmount = purchaseDtos.LineDiscountAmount;
                existingPurchaseDetails.LineDiscountPercentage = purchaseDtos.LineDiscountPercentage;
                existingPurchaseDetails.BatchNumber = purchaseDtos.BatchNumber ?? existingPurchaseDetails.BatchNumber;
                existingPurchaseDetails.ExpiryDate = purchaseDtos.ExpiryDate ?? existingPurchaseDetails.ExpiryDate;
                existingPurchaseDetails.SerialNumber = purchaseDtos.SerialNumber ?? existingPurchaseDetails.SerialNumber;
                existingPurchaseDetails.WarehouseLocation = purchaseDtos.WarehouseLocation ?? existingPurchaseDetails.WarehouseLocation;
                existingPurchaseDetails.ReceivedQuantity = purchaseDtos.ReceivedQuantity;
                existingPurchaseDetails.RejectedQuantity = purchaseDtos.RejectedQuantity;
                existingPurchaseDetails.LineTaxRate = purchaseDtos.LineTaxRate;
                existingPurchaseDetails.ExtraTax = purchaseDtos.ExtraTax ?? existingPurchaseDetails.ExtraTax;

                var updatedPurchaseDetails = _purchaseDetailsRepo.UpdatePurchaseDetails(id, existingPurchaseDetails);
                _logger.LogInformation("PurchaseDetails with ID: {idPurchaseDetails} updated successfully.", id);
                return updatedPurchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase details with ID: {idPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }
    }
}