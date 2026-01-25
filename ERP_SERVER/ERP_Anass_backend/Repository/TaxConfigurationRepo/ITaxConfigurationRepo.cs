using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.TaxConfigurationRepo
{
    public interface ITaxConfigurationRepo
    {
        List<TaxConfiguration> GetTaxConfigurations();
        TaxConfiguration GetTaxConfigurationById(int id);
        TaxConfiguration AddTaxConfiguration(TaxConfiguration taxConfiguration);
        TaxConfiguration UpdateTaxConfiguration(TaxConfiguration taxConfiguration);
        bool DeleteTaxConfiguration(int id);
    }
}
