using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace ERP_Anass_backend.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public float Password { get; set; }
        public float Status { get; set; }

        public float CreatedAt { get; set; }
        public float UpdatedAt { get; set; }
        public int Role { get; set; }
    }
}
