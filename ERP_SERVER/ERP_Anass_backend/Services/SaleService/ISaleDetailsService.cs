using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.SaleService
{
    public interface ISaleDetailsService
    {
        List<SaleDetails> GetSalesDetails();
        SaleDetails GetSalesDetailsById(int id);
        List<dynamic> GetSaleDetailsBySale(int id);
        SaleDetails AddSalesDetails(SaleDetailsDtos purchaseDtos);
        SaleDetails UpdateSalesDetails(int id, SaleDetailsDtos purchaseDtos);
        bool DeleteSalesDetails(int id);
    }
}
