using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.SaleRepo
{
    public interface ISaleDetailsRepo
    {

        List<SaleDetails> GetSaleDetails();
        SaleDetails GetSaleDetailsById(int id);
        List<dynamic> GetSaleDetailsBySale(int id);
        SaleDetails AddSaleDetails(SaleDetails purchaseDetails);
        SaleDetails UpdateSaleDetails(int id, SaleDetails purchaseDetails);
        bool DeleteSaleDetails(int id);
    }
}
