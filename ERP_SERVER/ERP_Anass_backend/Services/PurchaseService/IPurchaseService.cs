using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public interface IPurchaseService
    {

        List<Purchase> GetPurchases();
        Purchase GetPurchaseById(int id);
        Purchase AddPurchase(PurchaseDtos purchaseDtos);
        Purchase UpdatePurchase(int id,PurchaseDtos purchaseDtos);
        bool DeletePurchase(int id);
        List<dynamic> GetPurchaseDetails();
    }
}
