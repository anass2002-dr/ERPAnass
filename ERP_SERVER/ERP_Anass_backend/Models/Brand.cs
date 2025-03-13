using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandRef { get; set; }
        public string BrandName { get; set; }
        public Boolean IsAcitve { get; set; }
        public int? idFamilly { get; set; }

        [JsonIgnore]
        public Familly? Familly { get; set; }

        [JsonIgnore]
        public ICollection<Article> Article { get; set; } = [];
    }
}
