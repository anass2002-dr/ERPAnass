using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Modules
    {
        [Key]
        public int IdModule { get; set; }
        public string ModuleName { get; set; }
        public Boolean IsAcitve { get; set; }
        [JsonIgnore]
        public ICollection<Permission> Permission { get; set; } = new List<Permission>();
    }
}
