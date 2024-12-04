using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.PurchaseRepo
{
    public interface IPurchaseDetailsRepo
    {
        List<PurchaseDetails> GetPurchaseDetails();
        PurchaseDetails GetPurchaseDetailsById(int id);
        PurchaseDetails AddPurchaseDetails(PurchaseDetails purchaseDetails);
        PurchaseDetails UpdatePurchaseDetails(int id, PurchaseDetails purchaseDetails);
        bool DeletePurchaseDetails(int id);
    }
}
