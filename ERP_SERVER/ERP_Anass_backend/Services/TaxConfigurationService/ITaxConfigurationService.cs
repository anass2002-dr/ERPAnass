using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.TaxConfigurationService
{
    public interface ITaxConfigurationService
    {
        List<TaxConfiguration> GetTaxConfigurations();
        TaxConfiguration GetTaxConfigurationById(int id);
        TaxConfiguration AddTaxConfiguration(TaxConfiguration taxConfiguration);
        TaxConfiguration UpdateTaxConfiguration(TaxConfiguration taxConfiguration, int id);
        bool DeleteTaxConfiguration(int id);
    }
}
