using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseRepo : IPurchaseRepo
    {
        private readonly DbContextERP _dbContext;

        public PurchaseRepo(DbContextERP dbContextERP)
        {

            this._dbContext = dbContextERP;
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
                existingPurchase.IsAcitve = false;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public Purchase GetPurchaseById(int id)
        {
            return _dbContext.Purchases.Include(e => e.Supplier).Where(e => e.IdPurchase == id && e.IsAcitve && e.Supplier.IsAcitve && e.Currencyobj.IsAcitve).FirstOrDefault();
        }

        public List<dynamic> GetPurchaseDetails()
        {
            return _dbContext.Purchases.Include(e => e.Supplier).Where(e => e.IsAcitve && e.Supplier.IsAcitve && e.Currencyobj.IsAcitve).Select(
                e => new
                {
                    e.IdPurchase,
                    e.IsAcitve,
                    e.IdCurrency,
                    e.PaymentDate,
                    e.PaymentStatus,
                    e.PurchaseRef,
                    e.CreatedAt,
                    e.PurchaseDate,
                    e.Remarks,
                    e.Supplier.SupplierName,
                    e.Supplier.idSupplier,
                    e.Currencyobj.CurrencyName
                }).ToList<dynamic>();
        }

        public List<Purchase> GetPurchases()
        {
            return _dbContext.Purchases.Include(e => e.Supplier).Where(e => e.IsAcitve && e.Supplier.IsAcitve && e.Currencyobj.IsAcitve).ToList();

        }

        public Purchase UpdatePurchase(int id, Purchase purchase)
        {
            _dbContext.Purchases.Update(purchase);
            _dbContext.SaveChanges();
            return purchase;

        }
    }
}
