using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.ArticleRepo;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public class PurchaseDetailsRepo : IPurchaseDetailsRepo
    {
        private readonly DbContextERP _dbContextERP;
        private readonly IRepoArticle _repoArticle; // Use the interface for better abstraction.

        public PurchaseDetailsRepo(DbContextERP dbContextERP, IRepoArticle repoArticle)
        {
            _dbContextERP = dbContextERP;
            _repoArticle = repoArticle;
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
            if (existingPurchaseDetails == null)
            {
                return false; // Record doesn't exist, return false.
            }

            existingPurchaseDetails.IsActive = false;

            // Update the article stock quantity.
            if (_repoArticle != null)
            {
                var article = _repoArticle.GetArticleById(existingPurchaseDetails.idArticle);
                if (article != null && article.StockQuantity >= existingPurchaseDetails.Quantity)
                {
                    article.StockQuantity -= Convert.ToInt32(existingPurchaseDetails.Quantity);
                }
                else
                {
                    // Optionally, you can log or handle the case where stock quantity is insufficient.
                    return false; // Invalid state, cancel the operation.
                }
            }

            _dbContextERP.SaveChanges();
            return true;
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
