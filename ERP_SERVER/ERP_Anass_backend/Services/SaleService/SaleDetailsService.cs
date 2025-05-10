using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.SaleRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Services.SaleService
{
    public class SaleDetailsService : ISaleDetailsService
    {
        private readonly ISaleDetailsRepo _purchaseDetailsRepo;
        private readonly ILogger<SaleDetailsService> _logger;

        public SaleDetailsService(ISaleDetailsRepo purchaseDetailsRepo, ILogger<SaleDetailsService> logger)
        {
            _purchaseDetailsRepo = purchaseDetailsRepo;
            _logger = logger;
        }

        public SaleDetails AddSalesDetails(SaleDetailsDtos purchaseDtos)
        {
            try
            {
                // Validate DTO
                if (purchaseDtos == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDtos), "SaleDetails DTO cannot be null.");
                }

                // Map DTO to Model
                var purchaseDetails = new SaleDetails
                {
                    idArticle = purchaseDtos.idArticle,
                    Quantity = purchaseDtos.Quantity,
                    UnitPrice = purchaseDtos.UnitPrice,
                    TotalPrice = purchaseDtos.TotalPrice,
                    TaxAmount = purchaseDtos.TaxAmount,
                    Quality = purchaseDtos.Quality,
                    IsActive = purchaseDtos.IsActive,
                    IdSale = purchaseDtos.IdSale,

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
                    LineTaxRate = purchaseDtos.LineTaxRate
                };

                var addedSaleDetails = _purchaseDetailsRepo.AddSaleDetails(purchaseDetails);
                _logger.LogInformation("SaleDetails added successfully with ID: {IdSaleDetails}", addedSaleDetails.IdSaleDetails);
                return addedSaleDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeleteSalesDetails(int id)
        {
            try
            {
                bool isDeleted = _purchaseDetailsRepo.DeleteSaleDetails(id);
                if (isDeleted)
                {
                    _logger.LogInformation("SaleDetails with ID: {IdSaleDetails} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("SaleDetails with ID: {IdSaleDetails} not found for deletion.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase details with ID: {IdSaleDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetSaleDetailsBySale(int id)
        {
            try
            {
                var purchaseDetails = _purchaseDetailsRepo.GetSaleDetailsBySale(id);
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details for purchase ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<SaleDetails> GetSalesDetails()
        {
            try
            {
                var purchaseDetails = _purchaseDetailsRepo.GetSaleDetails();
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public SaleDetails GetSalesDetailsById(int id)
        {
            try
            {
                var purchaseDetails = _purchaseDetailsRepo.GetSaleDetailsById(id);
                if (purchaseDetails == null)
                {
                    _logger.LogWarning("SaleDetails with ID: {IdSaleDetails} not found.", id);
                }
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details with ID: {IdSaleDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public SaleDetails UpdateSalesDetails(int id, SaleDetailsDtos purchaseDtos)
        {
            try
            {
                var existingSaleDetails = _purchaseDetailsRepo.GetSaleDetailsById(id);
                if (existingSaleDetails == null)
                {
                    _logger.LogWarning("SaleDetails with ID: {IdSaleDetails} not found for update.", id);
                    throw new KeyNotFoundException($"SaleDetails with ID {id} not found.");
                }

                // Update fields if provided in DTO
                existingSaleDetails.Quantity = purchaseDtos.Quantity != 0 ? purchaseDtos.Quantity : existingSaleDetails.Quantity;
                existingSaleDetails.UnitPrice = purchaseDtos.UnitPrice != 0 ? purchaseDtos.UnitPrice : existingSaleDetails.UnitPrice;
                existingSaleDetails.TotalPrice = purchaseDtos.TotalPrice != 0 ? purchaseDtos.TotalPrice : existingSaleDetails.TotalPrice;
                existingSaleDetails.TaxAmount = purchaseDtos.TaxAmount != 0 ? purchaseDtos.TaxAmount : existingSaleDetails.TaxAmount;
                existingSaleDetails.Quality = purchaseDtos.Quality ?? existingSaleDetails.Quality;
                existingSaleDetails.IsActive = purchaseDtos.IsActive;

                // Update additional fields
                existingSaleDetails.LineItemStatus = purchaseDtos.LineItemStatus ?? existingSaleDetails.LineItemStatus;
                existingSaleDetails.UnitOfMeasure = purchaseDtos.UnitOfMeasure ?? existingSaleDetails.UnitOfMeasure;
                existingSaleDetails.LineDiscountAmount = purchaseDtos.LineDiscountAmount;
                existingSaleDetails.LineDiscountPercentage = purchaseDtos.LineDiscountPercentage;
                existingSaleDetails.BatchNumber = purchaseDtos.BatchNumber ?? existingSaleDetails.BatchNumber;
                existingSaleDetails.ExpiryDate = purchaseDtos.ExpiryDate ?? existingSaleDetails.ExpiryDate;
                existingSaleDetails.SerialNumber = purchaseDtos.SerialNumber ?? existingSaleDetails.SerialNumber;
                existingSaleDetails.WarehouseLocation = purchaseDtos.WarehouseLocation ?? existingSaleDetails.WarehouseLocation;
                existingSaleDetails.ReceivedQuantity = purchaseDtos.ReceivedQuantity;
                existingSaleDetails.RejectedQuantity = purchaseDtos.RejectedQuantity;
                existingSaleDetails.LineTaxRate = purchaseDtos.LineTaxRate;

                var updatedSaleDetails = _purchaseDetailsRepo.UpdateSaleDetails(id, existingSaleDetails);
                _logger.LogInformation("SaleDetails with ID: {IdSaleDetails} updated successfully.", id);
                return updatedSaleDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase details with ID: {IdSaleDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }
    }
}