using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseDetailsRepo : IPurchaseDetailsRepo
    {
        private readonly DbContextERP _dbContextERP;
        public PurchaseDetailsRepo(DbContextERP dbContextERP) 
        {
            this._dbContextERP = dbContextERP;
        }
        public PurchaseDetails AddPurchaseDetails(PurchaseDetails purchaseDetails)
        {
            _dbContextERP.PurchaseDetails.Add(purchaseDetails);
            _dbContextERP.SaveChanges();
            return purchaseDetails;
        }

        public bool DeletePurchaseDetails(int id)
        {
            var existingPurchaseDetails = GetPurchaseDetailsById(id);
            if (existingPurchaseDetails != null)
            {
                existingPurchaseDetails.IsActive = false;
                _dbContextERP.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public PurchaseDetails GetPurchaseDetailsById(int id)
        {
            return _dbContextERP.PurchaseDetails.Where(e=>e.IdPurchaseDetails==id && e.IsActive&&e.Purchase.IsAcitve).FirstOrDefault();
        }

        public List<PurchaseDetails> GetPurchaseDetails()
        {
            return _dbContextERP.PurchaseDetails.Where(e=>e.IsActive && e.Purchase.IsAcitve).ToList();
        }

        public PurchaseDetails UpdatePurchaseDetails(int id, PurchaseDetails purchaseDetails)
        {
            _dbContextERP.PurchaseDetails.Update(purchaseDetails);
            _dbContextERP.SaveChanges();
            return purchaseDetails;
        }

        public List<dynamic> GetPurchaseDetailsByPurchase(int id)
        {
            return _dbContextERP.PurchaseDetails.
                Where(e => e.IdPurchase == id && e.IsActive && e.Purchase.IsAcitve)
                .Include(e=>e.Article).
                Select(e =>new
                {
                    e.IdPurchase,
                    e.IdPurchaseDetails,
                    e.Quantity,
                    e.Quality,
                    e.TotalPrice,
                    e.IsActive,
                    e.Article
                })
                .ToList<dynamic>();
        }
    }
}
