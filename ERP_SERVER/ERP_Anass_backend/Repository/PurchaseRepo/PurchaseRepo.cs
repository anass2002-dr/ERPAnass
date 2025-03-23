using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseRepo : IPurchaseRepo
    {
        private readonly DbContextERP _dbContext;
        private readonly IPurchaseDetailsRepo _PurchaseDetailsRepo;
        private readonly ILogger<PurchaseRepo> _logger;
        public PurchaseRepo(DbContextERP dbContextERP, IPurchaseDetailsRepo PurchaseDetailsRepo, ILogger<PurchaseRepo> logger)
        {

            this._dbContext = dbContextERP;
            this._PurchaseDetailsRepo = PurchaseDetailsRepo;
            _logger = logger;
        }

        public Purchase AddPurchase(Purchase purchase)
        {
            try
            {
                // Validate purchase before adding
                if (purchase == null)
                {
                    throw new ArgumentNullException(nameof(purchase), "Purchase object cannot be null.");
                }

                // Set default values if not provided
                purchase.CreatedAt = DateTime.UtcNow;
                purchase.UpdatedAt = DateTime.UtcNow;
                purchase.IsActive = purchase.IsActive || true; // Default to true if not set

                _dbContext.Purchases.Add(purchase);
                _dbContext.SaveChanges();
                _logger.LogInformation("Purchase added successfully with ID: {IdPurchase}", purchase.IdPurchase);
                return purchase;
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
                var existingPurchase = GetPurchaseById(id);
                if (existingPurchase == null)
                {
                    _logger.LogWarning("Purchase with ID: {IdPurchase} not found for deletion.", id);
                    return false;
                }

                // Remove associated purchase details
                var purchaseDetails = _PurchaseDetailsRepo.GetPurchaseDetailsByPurchase(id);
                foreach (var purchaseDetailsItem in purchaseDetails)
                {
                    _PurchaseDetailsRepo.DeletePurchaseDetails(purchaseDetailsItem.IdPurchaseDetails);
                }

                // Remove the purchase
                _dbContext.Purchases.Remove(existingPurchase);
                _dbContext.SaveChanges();
                _logger.LogInformation("Purchase with ID: {IdPurchase} deleted successfully.", id);
                return true;
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
                var purchase = _dbContext.Purchases
                    .Include(p => p.Supplier)
                    .Include(p => p.Currencyobj)
                    .FirstOrDefault(p => p.IdPurchase == id);

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
                var purchases = _dbContext.Purchases
                    .AsNoTracking()
                    .Include(p => p.Supplier)
                    .Include(p => p.Currencyobj)
                    .Select(p => new
                    {
                        p.IdPurchase,
                        p.IsActive,
                        p.IdCurrency,
                        p.TotalAmount,
                        p.PaymentDate,
                        p.PaymentStatus,
                        p.PurchaseRef,
                        p.CreatedAt,
                        p.UpdatedAt,
                        p.PurchaseDate,
                        p.Remarks,
                        SupplierName = p.Supplier.SupplierName,
                        SupplierId = p.Supplier.idSupplier,
                        CurrencyName = p.Currencyobj.CurrencyName,
                        p.PurchaseStatus,
                        p.ExpectedDeliveryDate,
                        p.ActualDeliveryDate,
                        p.ShippingAddress,
                        p.PurchaseType,
                        p.DiscountAmount,
                        p.DiscountPercentage,
                        p.TaxRate,
                        p.TotalTaxAmount,
                        p.ExchangeRate,
                        p.ApprovedBy,
                        p.ApprovalDate,
                        p.PaymentTerms,
                        p.PurchaseChannel
                    }).ToList<dynamic>();

                return purchases;
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
                return _dbContext.Purchases
                    .AsNoTracking()
                    .Include(p => p.Supplier)
                    .Include(p => p.Currencyobj)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchases.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Purchase UpdatePurchase(int id, Purchase purchase)
        {
            _dbContext.Purchases.Update(purchase);
            _dbContext.SaveChanges();
            return purchase;

        }
    }
}
