using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.PurchaseRepo;
using System.ComponentModel;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public class PurchaseDetailsService : IPurchaseDetailsService
    {
        private readonly IPurchaseDetailsRepo _purchaseDeatilsRepo;
        public PurchaseDetailsService(IPurchaseDetailsRepo purchaseDetailsRepo)
        {
            this._purchaseDeatilsRepo = purchaseDetailsRepo;
        }
        public PurchaseDetails AddPurchasesDetails(PurchaseDetailsDtos purchaseDtos)
        {
            var PurchaseDt = new PurchaseDetails()
            {

                IdPurchaseDetails = purchaseDtos.IdPurchaseDetails,

                idArticle = purchaseDtos.idArticle,


                Quantity = purchaseDtos.Quantity,

                TotalPrice = purchaseDtos.TotalPrice,

                TaxAmount = purchaseDtos.TaxAmount,
                Quality = purchaseDtos.Quality,
                IsActive = purchaseDtos.IsActive,

                IdPurchase = purchaseDtos.IdPurchase,
            };
            return _purchaseDeatilsRepo.AddPurchaseDetails(PurchaseDt);
        }

        public bool DeletePurchasesDetails(int id)
        {
            return _purchaseDeatilsRepo.DeletePurchaseDetails(id);
        }

        public List<PurchaseDetails> GetPurchaseDetailsByPurchase(int id)
        {
            return _purchaseDeatilsRepo.GetPurchaseDetailsByPurchase(id);
        }

        public List<PurchaseDetails> GetPurchasesDetails()
        {
            return _purchaseDeatilsRepo.GetPurchaseDetails();
        }

        public PurchaseDetails GetPurchasesDetailsById(int id)
        {
            return _purchaseDeatilsRepo.GetPurchaseDetailsById(id);
        }

        public PurchaseDetails UpdatePurchasesDetails(int id, PurchaseDetailsDtos purchaseDtos)
        {
            var existingobj = _purchaseDeatilsRepo.GetPurchaseDetailsById(id);
            if(existingobj != null)
            {
                existingobj.IdPurchaseDetails = purchaseDtos.IdPurchaseDetails==0?existingobj.IdPurchaseDetails :purchaseDtos.IdPurchaseDetails;
                existingobj.idArticle =purchaseDtos.idArticle == 0?existingobj.idArticle :purchaseDtos.idArticle;
                existingobj.Quantity = purchaseDtos.idArticle == 0 ? existingobj.idArticle : purchaseDtos.idArticle;
                existingobj.TotalPrice =purchaseDtos.TotalPrice == 0 ? existingobj.TotalPrice : purchaseDtos.TotalPrice;
                existingobj.TaxAmount = purchaseDtos.TaxAmount == 0 ? existingobj.TaxAmount : purchaseDtos.TaxAmount;
                existingobj.Quality = string.IsNullOrEmpty(purchaseDtos.Quality)?existingobj.Quality :purchaseDtos.Quality;
                existingobj.IsActive = existingobj.IsActive;
                existingobj.IdPurchase = purchaseDtos.IdPurchase == 0 ? existingobj.IdPurchase : purchaseDtos.IdPurchase;

            }
            return _purchaseDeatilsRepo.UpdatePurchaseDetails(id, existingobj);
        }
    }
}
