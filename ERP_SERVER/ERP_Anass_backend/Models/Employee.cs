using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public DateTime DateOfBirth { get; set; }


        public string Email { get; set; }


        public string Phone { get; set; }

        public string Address { get; set; }


        public string JobTitle { get; set; }

        public int DepartmentID { get; set; }
        public int WorksID { get; set; }

        public DateTime StartDate { get; set; }


        public decimal Salary { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int CityID { get; set; }
        public int CountryId { get; set; }
        [JsonIgnore]
        public Department Department { get; set; }
        [JsonIgnore]
        public Works Works { get; set; }
        [JsonIgnore]
        public City City   { get; set; }
        [JsonIgnore]
        public Country Country{ get; set; }
    }
}
