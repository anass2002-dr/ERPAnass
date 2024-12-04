using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.PurchaseRepo;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepo _purchaseRepo;
        public PurchaseService(IPurchaseRepo purchaseRepo)
        {
            this._purchaseRepo = purchaseRepo;
        }

        public Purchase AddPurchase(PurchaseDtos purchaseDtos)
        {
            var purchase = new Purchase
            {
                PurchaseRef = purchaseDtos.PurchaseRef,
                SupplierName = purchaseDtos.SupplierName,
                TotalAmount = purchaseDtos.TotalAmount,
                Currency = purchaseDtos.Currency,
                PaymentStatus = purchaseDtos.PaymentStatus,
                PaymentDate = purchaseDtos.PaymentDate,
                CreatedAt = DateTime.Today,
                UpdatedAt = DateTime.Today,
                Remarks = purchaseDtos.Remarks,
                idSupplier = purchaseDtos.idSupplier,
                IsAcitve = purchaseDtos.IsAcitve
            };
            return _purchaseRepo.AddPurchase(purchase);
        }

        public bool DeletePurchase(int id)
        {
            return _purchaseRepo.DeletePurchase(id);
        }

        public Purchase GetPurchaseById(int id)
        {
            return _purchaseRepo.GetPurchaseById(id);
        }

        public List<dynamic> GetPurchaseDetails()
        {
            return _purchaseRepo.GetPurchaseDetails();
        }

        public List<Purchase> GetPurchases()
        {
            return _purchaseRepo.GetPurchases();
        }

        public Purchase UpdatePurchase(int id, PurchaseDtos purchaseDtos)
        {
            
            var existingPurchase= _purchaseRepo.GetPurchaseById(id);
            if (existingPurchase != null)
            {
                existingPurchase.PurchaseRef = string.IsNullOrEmpty(purchaseDtos.PurchaseRef) ? existingPurchase.PurchaseRef : purchaseDtos.PurchaseRef;
                existingPurchase.SupplierName = string.IsNullOrEmpty(purchaseDtos.SupplierName) ? existingPurchase.SupplierName : purchaseDtos.SupplierName;
                existingPurchase.PaymentStatus = string.IsNullOrEmpty(purchaseDtos.PaymentStatus) ? existingPurchase.PaymentStatus : purchaseDtos.PaymentStatus;
                existingPurchase.Remarks = string.IsNullOrEmpty(purchaseDtos.Remarks) ? existingPurchase.Remarks : purchaseDtos.Remarks;
                existingPurchase.TotalAmount = purchaseDtos.TotalAmount==-1 ? existingPurchase.TotalAmount : purchaseDtos.TotalAmount;
                existingPurchase.Currency = string.IsNullOrEmpty(purchaseDtos.Currency) ? existingPurchase.Currency : purchaseDtos.Currency;
                existingPurchase.UpdatedAt =DateTime.Today;
                existingPurchase.idSupplier = purchaseDtos.idSupplier==0 ? existingPurchase.idSupplier : purchaseDtos.idSupplier;
                existingPurchase.PaymentDate =purchaseDtos.PaymentDate;
                 
            }
            return _purchaseRepo.UpdatePurchase(id, existingPurchase);
        }
    }
}
