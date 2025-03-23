using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseRepo : IPurchaseRepo
    {
        private readonly DbContextERP _dbContext;
        private readonly IPurchaseDetailsRepo _PurchaseDetailsRepo;
        public PurchaseRepo(DbContextERP dbContextERP, IPurchaseDetailsRepo PurchaseDetailsRepo)
        {

            this._dbContext = dbContextERP;
            this._PurchaseDetailsRepo = PurchaseDetailsRepo;
        }

        public Purchase AddPurchase(Purchase purchase)
        {
            _dbContext.Purchases.Add(purchase);
            _dbContext.SaveChanges();
            return purchase;
        }

        public bool DeletePurchase(int id)
        {
            var existingPurchase = GetPurchaseById(id);
            if (existingPurchase != null)
            {

                _dbContext.Purchases.Remove(existingPurchase);

                var purchaseDetails = _PurchaseDetailsRepo.GetPurchaseDetailsByPurchase(id);
                foreach (var purchaseDetailsItem in purchaseDetails)
                {
                    _PurchaseDetailsRepo.DeletePurchaseDetails(purchaseDetailsItem.IdPurchaseDetails); // Ensure correct property
                }

                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }

        public Purchase GetPurchaseById(int id)
        {
            return _dbContext.Purchases.FirstOrDefault(s => s.IdPurchase == id);
        }

        public List<dynamic> GetPurchaseDetails()
        {
            return _dbContext.Purchases.AsNoTracking().Include(e => e.Supplier).Select(
                e => new
                {
                    e.IdPurchase,
                    e.IsAcitve,
                    e.IdCurrency,
                    e.TotalAmount,
                    e.PaymentDate,
                    e.PaymentStatus,
                    e.PurchaseRef,
                    e.CreatedAt,
                    e.UpdatedAt,
                    e.PurchaseDate,
                    e.Remarks,
                    e.Supplier.SupplierName,
                    e.Supplier.idSupplier,
                    e.Currencyobj.CurrencyName
                }).ToList<dynamic>();
        }

        public List<Purchase> GetPurchases()
        {
            return _dbContext.Purchases.AsNoTracking().Include(e => e.Supplier).ToList();

        }

        public Purchase UpdatePurchase(int id, Purchase purchase)
        {
            _dbContext.Purchases.Update(purchase);
            _dbContext.SaveChanges();
            return purchase;

        }
    }
}
