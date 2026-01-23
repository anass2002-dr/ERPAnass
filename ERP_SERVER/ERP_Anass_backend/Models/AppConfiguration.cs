using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public class AppConfiguration : BaseEntity
    {
        [Key]
        public int idAppConfiguration { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
