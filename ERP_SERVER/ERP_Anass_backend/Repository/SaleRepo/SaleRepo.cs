using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.SaleRepo;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.SaleRepo
{
    public class SaleRepo:ISaleRepo
    {
        private readonly DbContextERP _dbContext;
        private readonly ISaleDetailsRepo _SaleDetailsRepo;
        private readonly ILogger<SaleRepo> _logger;
        public SaleRepo(DbContextERP dbContextERP, ISaleDetailsRepo SaleDetailsRepo, ILogger<SaleRepo> logger)
        {

            this._dbContext = dbContextERP;
            this._SaleDetailsRepo = SaleDetailsRepo;
            _logger = logger;
        }

        public Sale AddSale(Sale purchase)
        {
            try
            {
                // Validate purchase before adding
                if (purchase == null)
                {
                    throw new ArgumentNullException(nameof(purchase), "Sale object cannot be null.");
                }

                // Set default values if not provided
                purchase.CreatedAt = DateTime.UtcNow;
                purchase.UpdatedAt = DateTime.UtcNow;

                _dbContext.Sale.Add(purchase);
                _dbContext.SaveChanges();
                _logger.LogInformation("Sale added successfully with ID: {IdSale}", purchase.IdSale);
                return purchase;
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
                var existingSale = GetSaleById(id);
                if (existingSale == null)
                {
                    _logger.LogWarning("Sale with ID: {IdSale} not found for deletion.", id);
                    return false;
                }

                // Remove associated purchase details
                var purchaseDetails = _SaleDetailsRepo.GetSaleDetailsBySale(id);
                foreach (var purchaseDetailsItem in purchaseDetails)
                {
                    _SaleDetailsRepo.DeleteSaleDetails(purchaseDetailsItem.IdSaleDetails);
                }

                // Remove the purchase
                _dbContext.Sale.Remove(existingSale);
                _dbContext.SaveChanges();
                _logger.LogInformation("Sale with ID: {IdSale} deleted successfully.", id);
                return true;
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
                var purchase = _dbContext.Sale
                    .Include(p => p.Customerobj)
                    .Include(p => p.Currencyobj)
                    .FirstOrDefault(p => p.IdSale == id);

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
                var purchases = _dbContext.Sale
                    .AsNoTracking()
                    .Include(p => p.Customerobj)
                    .Include(p => p.Currencyobj)
                    .Select(p => new
                    {
                        p.IdSale,
                        p.IsActive,
                        p.IdCurrency,
                        p.TotalAmount,
                        p.TotalPayment,
                        p.PaymentDate,
                        p.PaymentStatus,
                        p.SaleRef,
                        p.CreatedAt,
                        p.UpdatedAt,
                        p.SaleDate,
                        p.Remarks,
                        CustomerName = p.Customerobj.CustomerName,
                        CustomerId = p.Customerobj.idCustomer,
                        CurrencyName = p.Currencyobj.CurrencyName,
                        p.SaleStatus,
                        p.ExpectedDeliveryDate,
                        p.ActualDeliveryDate,
                        p.ShippingAddress,
                        p.SaleType,
                        p.DiscountAmount,
                        p.ShippingAmount,
                        p.DiscountPercentage,
                        p.TaxRate,
                        p.TotalTaxAmount,
                        p.ExchangeRate,
                        p.ApprovedBy,
                        p.ApprovalDate,
                        p.PaymentTerms,
                        p.SaleChannel
                    }).ToList<dynamic>();

                return purchases;
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
                return _dbContext.Sale
                    .AsNoTracking()
                    .Include(p => p.Customerobj)
                    .Include(p => p.Currencyobj)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching all purchases.");
                throw; // Re-throw the exception for handling at a higher level
            }
        }

        public Sale UpdateSale(int id, Sale purchase)
        {
            _dbContext.Sale.Update(purchase);
            _dbContext.SaveChanges();
            return purchase;

        }
    }
}
