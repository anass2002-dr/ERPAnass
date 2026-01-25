using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.TaxConfigurationRepo
{
    public class TaxConfigurationRepo : ITaxConfigurationRepo
    {
        private readonly DbContextERP _context;

        public TaxConfigurationRepo(DbContextERP context)
        {
            _context = context;
        }

        public List<TaxConfiguration> GetTaxConfigurations()
        {
            return _context.TaxConfigurations.AsNoTracking().Where(t => t.IsAcitve).ToList();
        }

        public TaxConfiguration GetTaxConfigurationById(int id)
        {
            return _context.TaxConfigurations.FirstOrDefault(t => t.idTaxConfig == id);
        }

        public TaxConfiguration AddTaxConfiguration(TaxConfiguration taxConfiguration)
        {
            _context.TaxConfigurations.Add(taxConfiguration);
            _context.SaveChanges();
            return taxConfiguration;
        }

        public TaxConfiguration UpdateTaxConfiguration(TaxConfiguration taxConfiguration)
        {
            _context.TaxConfigurations.Update(taxConfiguration);
            _context.SaveChanges();
            return taxConfiguration;
        }

        public bool DeleteTaxConfiguration(int id)
        {
            var tax = _context.TaxConfigurations.FirstOrDefault(t => t.idTaxConfig == id);
            if (tax == null) return false;
            
            tax.IsAcitve = false; // Soft delete
            _context.TaxConfigurations.Update(tax);
            _context.SaveChanges();
            return true;
        }
    }
}
