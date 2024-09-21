using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Country
    {
        public int CountryId {get; set;}
        public string CountryName { get; set;}

        [JsonIgnore]
        public ICollection<City> City { get; set; } = [];
    }
}
