using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.SaleRepo
{
    public interface ISaleRepo
    {

        List<Sale> GetSales();
        Sale GetSaleById(int id);
        Sale AddSale(Sale purchase);
        Sale UpdateSale(int id, Sale purchase);
        bool DeleteSale(int id);
        List<dynamic> GetSaleDetails();
    }
}
