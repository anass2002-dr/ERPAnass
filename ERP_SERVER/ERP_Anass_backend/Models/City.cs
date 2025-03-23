using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int zipCode { get; set; }
        public int? CountryId { get; set; }

        public Boolean IsAcitve { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = [];
        [JsonIgnore]
        public ICollection<Supplier> Supplier { get; set; } = [];
    }
}
