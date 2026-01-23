using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.SaleService
{
    public interface ISaleService
    {

        List<Sale> GetSales();
        Sale GetSaleById(int id);
        Sale AddSale(SaleDtos purchaseDtos);
        Sale UpdateSale(int id,SaleDtos purchaseDtos);
        bool DeleteSale(int id);
        List<dynamic> GetSaleDetails();
        Sale checkRef(string reff);
        void FinalizeSale(int saleId, int paymentId);
    }
}
