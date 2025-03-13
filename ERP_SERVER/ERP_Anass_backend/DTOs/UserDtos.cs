using ERP_Anass_backend.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.DTOs
{
    public class UserDtos
    {

        public Guid UserID { get; set; } = Guid.NewGuid();
        [DefaultValue(null)]
        public string FirstName { get; set; }

        [DefaultValue(null)]
        public string LastName { get; set; }
        [DefaultValue(null)]
        public string Email { get; set; }

        [DefaultValue(null)]
        public string Password { get; set; }  // Consider storing only hashed passwords

        [DefaultValue(null)]
        public string Status { get; set; }

        [DefaultValue(typeof(DateTime), "")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DefaultValue(typeof(DateTime), "")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [DefaultValue(null)]
        public string Role { get; set; }

        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }
        // Constructor to map User model to UserDtos
        public UserDtos(User user)
        {
            this.UserID=user.UserID;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Email = user.Email;
            this.Password = user.Password;  // Store only hashed passwords in practice
            this.Status = user.Status;
            this.CreatedAt = user.CreatedAt;
            this.UpdatedAt = user.UpdatedAt;
            this.Role = user.Role;
            this.IsAcitve = user.IsAcitve;
        }

        // Parameterless constructor
        public UserDtos() { }
    }
}
