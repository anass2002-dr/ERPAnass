using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.PurchaseService
{
    public interface IPurchaseDetailsService
    {
        List<PurchaseDetails> GetPurchasesDetails();
        PurchaseDetails GetPurchasesDetailsById(int id);
        List<PurchaseDetails> GetPurchaseDetailsByPurchase(int id);
        PurchaseDetails AddPurchasesDetails(PurchaseDetailsDtos purchaseDtos);
        PurchaseDetails UpdatePurchasesDetails(int id, PurchaseDetailsDtos purchaseDtos);
        bool DeletePurchasesDetails(int id);
    }
}
