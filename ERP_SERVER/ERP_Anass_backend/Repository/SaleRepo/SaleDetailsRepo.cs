using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.ArticleRepo;
using ERP_Anass_backend.Repository.SaleRepo;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.SaleRepo
{
    public class SaleDetailsRepo:ISaleDetailsRepo
    {

        private readonly DbContextERP _dbContextERP;
        private readonly IRepoArticle _repoArticle; // Use the interface for better abstraction.
        private readonly ILogger<SaleDetailsRepo> _logger;

        public SaleDetailsRepo(DbContextERP dbContextERP, IRepoArticle repoArticle, ILogger<SaleDetailsRepo> logger)
        {
            _dbContextERP = dbContextERP;
            _repoArticle = repoArticle;
            _logger = logger;
        }

        public SaleDetails AddSaleDetails(SaleDetails purchaseDetails)
        {
            try
            {
                // Validate purchaseDetails before adding
                if (purchaseDetails == null)
                {
                    throw new ArgumentNullException(nameof(purchaseDetails), "SaleDetails object cannot be null.");
                }

                // Set default values if not provided
                purchaseDetails.IsActive = purchaseDetails.IsActive || true; // Default to true if not set

                _dbContextERP.SaleDetails.Add(purchaseDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("SaleDetails added successfully with ID: {IdSaleDetails}", purchaseDetails.IdSaleDetails);
                return purchaseDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public bool DeleteSaleDetails(int id)
        {
            try
            {
                var existingSaleDetails = GetSaleDetailsById(id);
                if (existingSaleDetails == null)
                {
                    _logger.LogWarning("SaleDetails with ID: {IdSaleDetails} not found for deletion.", id);
                    return false; // Record doesn't exist, return false.
                }

                // Update the article stock quantity.
                if (_repoArticle != null)
                {
                    var article = _repoArticle.GetArticleById(Convert.ToInt32(existingSaleDetails.idArticle));
                    if (article != null && article.StockQuantity >= existingSaleDetails.Quantity)
                    {
                        article.StockQuantity -= Convert.ToInt32(existingSaleDetails.Quantity);
                        _dbContextERP.Article.Update(article);
                    }
                    else
                    {
                        _logger.LogWarning("Insufficient stock for article ID: {IdArticle} when deleting purchase details ID: {IdSaleDetails}.", existingSaleDetails.idArticle, id);
                        return false; // Invalid state, cancel the operation.
                    }
                }

                _dbContextERP.SaleDetails.Remove(existingSaleDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("SaleDetails with ID: {IdSaleDetails} deleted successfully.", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting purchase details with ID: {IdSaleDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public SaleDetails GetSaleDetailsById(int id)
        {
            try
            {
                var purchaseDetails = _dbContextERP.SaleDetails
                    .Include(pd => pd.Sale)
                    .FirstOrDefault(pd => pd.IdSaleDetails == id);

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

        public List<SaleDetails> GetSaleDetails()
        {
            try
            {
                return _dbContextERP.SaleDetails
                    .Include(pd => pd.Sale)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchase details.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public SaleDetails UpdateSaleDetails(int id, SaleDetails purchaseDetails)
        {
            try
            {
                var existingSaleDetails = GetSaleDetailsById(id);
                if (existingSaleDetails == null)
                {
                    _logger.LogWarning("SaleDetails with ID: {IdSaleDetails} not found for update.", id);
                    throw new KeyNotFoundException($"SaleDetails with ID {id} not found.");
                }

                // Update fields
                existingSaleDetails.Quantity = purchaseDetails.Quantity;
                existingSaleDetails.UnitPrice = purchaseDetails.UnitPrice;
                existingSaleDetails.TotalPrice = purchaseDetails.TotalPrice;
                existingSaleDetails.TaxAmount = purchaseDetails.TaxAmount;
                existingSaleDetails.Quality = purchaseDetails.Quality;
                existingSaleDetails.IsActive = purchaseDetails.IsActive;

                // Update additional fields
                existingSaleDetails.LineItemStatus = purchaseDetails.LineItemStatus;
                existingSaleDetails.UnitOfMeasure = purchaseDetails.UnitOfMeasure;
                existingSaleDetails.LineDiscountAmount = purchaseDetails.LineDiscountAmount;
                existingSaleDetails.LineDiscountPercentage = purchaseDetails.LineDiscountPercentage;
                existingSaleDetails.BatchNumber = purchaseDetails.BatchNumber;
                existingSaleDetails.ExpiryDate = purchaseDetails.ExpiryDate;
                existingSaleDetails.SerialNumber = purchaseDetails.SerialNumber;
                existingSaleDetails.WarehouseLocation = purchaseDetails.WarehouseLocation;
                existingSaleDetails.ReceivedQuantity = purchaseDetails.ReceivedQuantity;
                existingSaleDetails.RejectedQuantity = purchaseDetails.RejectedQuantity;
                existingSaleDetails.LineTaxRate = purchaseDetails.LineTaxRate;

                _dbContextERP.SaleDetails.Update(existingSaleDetails);
                _dbContextERP.SaveChanges();
                _logger.LogInformation("SaleDetails with ID: {IdSaleDetails} updated successfully.", id);
                return existingSaleDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating purchase details with ID: {IdSaleDetails}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public List<dynamic> GetSaleDetailsBySale(int id)
        {
            try
            {
                return _dbContextERP.SaleDetails
                    .Where(pd => pd.IdSale == id)
                    .Include(pd => pd.Article)
                    .Select(pd => new
                    {
                        pd.IdSale,
                        pd.IdSaleDetails,
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
                _logger.LogError(ex, "Error occurred while fetching purchase details for purchase ID: {IdSale}.", id);
                throw; // Re-throw the exception for handling at a higher level
            }
        }
    }
}
