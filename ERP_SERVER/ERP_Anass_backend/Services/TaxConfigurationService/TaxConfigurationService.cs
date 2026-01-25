using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.TaxConfigurationRepo;

namespace ERP_Anass_backend.Services.TaxConfigurationService
{
    public class TaxConfigurationService : ITaxConfigurationService
    {
        private readonly ITaxConfigurationRepo _taxRepo;

        public TaxConfigurationService(ITaxConfigurationRepo taxRepo)
        {
            _taxRepo = taxRepo;
        }

        public List<TaxConfiguration> GetTaxConfigurations()
        {
            return _taxRepo.GetTaxConfigurations();
        }

        public TaxConfiguration GetTaxConfigurationById(int id)
        {
            return _taxRepo.GetTaxConfigurationById(id);
        }

        public TaxConfiguration AddTaxConfiguration(TaxConfiguration taxConfiguration)
        {
            return _taxRepo.AddTaxConfiguration(taxConfiguration);
        }

        public TaxConfiguration UpdateTaxConfiguration(TaxConfiguration taxConfiguration, int id)
        {
            var existing = _taxRepo.GetTaxConfigurationById(id);
            if (existing == null) return null;
            
            existing.TaxName = taxConfiguration.TaxName;
            existing.TaxRate = taxConfiguration.TaxRate;
            existing.Description = taxConfiguration.Description;
            // Add other fields update if necessary

            return _taxRepo.UpdateTaxConfiguration(existing);
        }

        public bool DeleteTaxConfiguration(int id)
        {
            return _taxRepo.DeleteTaxConfiguration(id);
        }
    }
}
