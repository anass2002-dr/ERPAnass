using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace ERP_Anass_backend.Models
{
    public class Currency
    {
        [Key]
        public int IdCurrency { get; set; }
        public string CurrencyName { get; set; }
        public Boolean IsAcitve { get; set; }

        [JsonIgnore]
        public ICollection<Purchase> Purchases { get; set; } = [];
        [JsonIgnore]
        public ICollection<Sale> Sales { get; set; } = [];
    }
}
