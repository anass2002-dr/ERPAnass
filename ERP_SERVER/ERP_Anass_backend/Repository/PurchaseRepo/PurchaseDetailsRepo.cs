using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.ArticleRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseDetailsRepo : IPurchaseDetailsRepo
    {
        private readonly DbContextERP _dbContextERP;
        private readonly IRepoArticle _repoArticle; // Use the interface for better abstraction.
        private readonly ILogger<PurchaseDetailsRepo> _logger;

        public PurchaseDetailsRepo(DbContextERP dbContextERP, IRepoArticle repoArticle, ILogger<PurchaseDetailsRepo> logger)
        {
            _dbContextERP = dbContextERP;
            _repoArticle = repoArticle;
            _logger = logger;
        }

        public PurchaseDetails AddPurchaseDetails(PurchaseDetails purchaseDetails)
        {
            try
            {
                // Validate purchaseDetails before adding
                if (purchaseDetails == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDetails), "PurchaseDetails object cannot be null.");
                }

                // Set default values if not provided
                purchaseDetails.IsActive = purchaseDetails.IsActive || true; // Default to true if not set

                _dbContextERP.PurchaseDetails.Add(purchaseDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("PurchaseDetails added successfully with ID: {IdPurchaseDetails}", purchaseDetails.IdPurchaseDetails);
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeletePurchaseDetails(int id)
        {
            try
            {
                var existingPurchaseDetails = GetPurchaseDetailsById(id);
                if (existingPurchaseDetails == null)
                {
                    _logger.LogWarning("PurchaseDetails with ID: {IdPurchaseDetails} not found for deletion.", id);
                    return false; // Record doesn't exist, return false.
                }

                // Update the article stock quantity.
                if (_repoArticle != null)
                {
                    var article = _repoArticle.GetArticleById(Convert.ToInt32(existingPurchaseDetails.idArticle));
                    if (article != null && article.StockQuantity >= existingPurchaseDetails.Quantity)
                    {
                        article.StockQuantity -= Convert.ToInt32(existingPurchaseDetails.Quantity);
                        _dbContextERP.Article.Update(article);
                    }
                    else
                    {
                        _logger.LogWarning("Insufficient stock for article ID: {IdArticle} when deleting purchase details ID: {IdPurchaseDetails}.", existingPurchaseDetails.idArticle, id);
                        return false; // Invalid state, cancel the operation.
                    }
                }

                _dbContextERP.PurchaseDetails.Remove(existingPurchaseDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("PurchaseDetails with ID: {IdPurchaseDetails} deleted successfully.", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase details with ID: {IdPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public PurchaseDetails GetPurchaseDetailsById(int id)
        {
            try
            {
                var purchaseDetails = _dbContextERP.PurchaseDetails
                    .Include(pd => pd.Purchase)
                    .FirstOrDefault(pd => pd.IdPurchaseDetails == id );

                if (purchaseDetails == null)
                {
                    _logger.LogWarning("PurchaseDetails with ID: {IdPurchaseDetails} not found.", id);
                }

                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details with ID: {IdPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<PurchaseDetails> GetPurchaseDetails()
        {
            try
            {
                return _dbContextERP.PurchaseDetails
                    .Include(pd => pd.Purchase)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public PurchaseDetails UpdatePurchaseDetails(int id, PurchaseDetails purchaseDetails)
        {
            try
            {
                var existingPurchaseDetails = GetPurchaseDetailsById(id);
                if (existingPurchaseDetails == null)
                {
                    _logger.LogWarning("PurchaseDetails with ID: {IdPurchaseDetails} not found for update.", id);
                    throw new KeyNotFoundException($"PurchaseDetails with ID {id} not found.");
                }

                // Update fields
                existingPurchaseDetails.Quantity = purchaseDetails.Quantity;
                existingPurchaseDetails.UnitPrice = purchaseDetails.UnitPrice;
                existingPurchaseDetails.TotalPrice = purchaseDetails.TotalPrice;
                existingPurchaseDetails.TaxAmount = purchaseDetails.TaxAmount;
                existingPurchaseDetails.Quality = purchaseDetails.Quality;
                existingPurchaseDetails.IsActive = purchaseDetails.IsActive;

                // Update additional fields
                existingPurchaseDetails.LineItemStatus = purchaseDetails.LineItemStatus;
                existingPurchaseDetails.UnitOfMeasure = purchaseDetails.UnitOfMeasure;
                existingPurchaseDetails.LineDiscountAmount = purchaseDetails.LineDiscountAmount;
                existingPurchaseDetails.LineDiscountPercentage = purchaseDetails.LineDiscountPercentage;
                existingPurchaseDetails.BatchNumber = purchaseDetails.BatchNumber;
                existingPurchaseDetails.ExpiryDate = purchaseDetails.ExpiryDate;
                existingPurchaseDetails.SerialNumber = purchaseDetails.SerialNumber;
                existingPurchaseDetails.WarehouseLocation = purchaseDetails.WarehouseLocation;
                existingPurchaseDetails.ReceivedQuantity = purchaseDetails.ReceivedQuantity;
                existingPurchaseDetails.RejectedQuantity = purchaseDetails.RejectedQuantity;
                existingPurchaseDetails.LineTaxRate = purchaseDetails.LineTaxRate;

                _dbContextERP.PurchaseDetails.Update(existingPurchaseDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("PurchaseDetails with ID: {IdPurchaseDetails} updated successfully.", id);
                return existingPurchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase details with ID: {IdPurchaseDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetPurchaseDetailsByPurchase(int id)
        {
            try
            {
                return _dbContextERP.PurchaseDetails
                    .Where(pd => pd.IdPurchase == id)
                    .Include(pd => pd.Article)
                    .Select(pd => new
                    {
                        pd.IdPurchase,
                        pd.IdPurchaseDetails,
                        pd.Quantity,
                        pd.Quality,
                        pd.TotalPrice,
                        pd.IsActive,
                        Article = new
                        {
                            pd.Article.idArticle,
                            pd.Article.ArticleName,
                            pd.Article.StockQuantity
                        }
                    })
                    .ToList<dynamic>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching purchase details for purchase ID: {IdPurchase}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }
    }
}