using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Country
    {
        public int CountryId {get; set;}
        public string CountryName { get; set;}

        public Boolean IsAcitve { get; set;}
        [JsonIgnore]
        public ICollection<City> City { get; set; } = [];
        [JsonIgnore]
        public ICollection<Supplier> Supplier { get; set; } = [];
        [JsonIgnore]
        public ICollection<Customer> Customer { get; set; } = [];
        [JsonIgnore]
        public ICollection<Employee> Employees{ get; set; } = [];
    }
}
