using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public abstract class BaseEntity
    {
        public Guid TenantId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public Boolean IsAcitve { get; set; } = true;
    }
}
