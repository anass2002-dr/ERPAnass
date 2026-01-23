using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace ERP_Anass_backend.Models
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }
        public string? CustomerRef { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactPerson { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Boolean? IsAcitve { get; set; }
        public string? IdentityNumber { get; set; }

        public int? idControlAccount { get; set; }
        [JsonIgnore]
        public Account? ControlAccount { get; set; }

        public int? CountryId { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }

        public int? CityID { get; set; }
        [JsonIgnore]
        public City? City { get; set; }
        [JsonIgnore]
        public ICollection<Sale> Sales { get; set; } = [];
    }
}
