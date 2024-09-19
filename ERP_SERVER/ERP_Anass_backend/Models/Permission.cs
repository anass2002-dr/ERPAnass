using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Permission
    {
        [Key]
        public int IdPermission { get; set; }

        // Changed the type of UserId to Guid to match the primary key in User
        public Guid UserId { get; set; }

        public int IdModule { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }

        [JsonIgnore]
        public Modules Modules { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
