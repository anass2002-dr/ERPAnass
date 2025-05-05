using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace ERP_Anass_backend.Models
{
    public class Supplier
    {
        [Key]
        public int idSupplier { get; set; }
        public string? SupplierRef { get; set; }
        public string? SupplierName { get; set; }
        public string? ContactPerson { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Boolean? IsAcitve { get; set; }
        public string? IdentityNumber { get; set; }

        public int? CountryId { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }

        public int? CityID { get; set; }
        [JsonIgnore]
        public City? City { get; set; }
        [JsonIgnore]
        public ICollection<Purchase> Purchase { get; set; } = [];
    }
}
