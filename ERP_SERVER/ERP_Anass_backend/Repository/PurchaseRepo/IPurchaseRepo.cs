using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public interface IPurchaseRepo
    {
        List<Purchase> GetPurchases();
        Purchase GetPurchaseById(int id);
        Purchase AddPurchase(Purchase purchase);
        Purchase UpdatePurchase(int id, Purchase purchase);
        bool DeletePurchase(int id);
        List<dynamic> GetPurchaseDetails();
    }
}
