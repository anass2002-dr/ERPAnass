using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public interface IPurchaseDetailsRepo
    {
        List<PurchaseDetails> GetPurchaseDetails();

        Purchase GetPurchaseById(int id);
        PurchaseDetails GetPurchaseDetailsById(int id);
        List<dynamic> GetPurchaseDetailsByPurchase(int id);
        PurchaseDetails AddPurchaseDetails(PurchaseDetails purchaseDetails);
        PurchaseDetails UpdatePurchaseDetails(int id, PurchaseDetails purchaseDetails);
        bool DeletePurchaseDetails(int id);
    }
}
