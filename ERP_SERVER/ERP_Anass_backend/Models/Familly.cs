using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Familly
    {
        [Key]
        public int idFamilly { get; set; }
        public string familyRef { get; set; }
        public string familyName { get; set; }
        public string familyDesc { get; set; }
        [JsonIgnore]
        public ICollection<Article> Article { get; set; } = [];

    }
}
