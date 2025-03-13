using ERP_Anass_backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class EmployeeDtos
    {
        [DefaultValue(0)]
        public int EmployeeID { get; set; }
        [DefaultValue(null)]
        public string FirstName { get; set; }
        [DefaultValue(null)]
        public string LastName { get; set; }
        [DefaultValue(typeof(DateTime), "")]
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
        [DefaultValue(null)]
        public string Email { get; set; }
        [DefaultValue(null)]
        public string Phone { get; set; }
        [DefaultValue(null)]
        public string Address { get; set; }
        [DefaultValue(null)]
        public string JobTitle { get; set; }

        [DefaultValue(0)]
        public int DepartmentID { get; set; }

        // Foreign Key for Works
        [DefaultValue(0)]
        public int? WorksID { get; set; }

        [DefaultValue(typeof(DateTime), "")]
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        [DefaultValue(0)]
        public decimal Salary { get; set; }
        [DefaultValue(typeof(DateTime), "")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [DefaultValue(typeof(DateTime), "")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [DefaultValue(0)]
        public int? CityID { get; set; }
        [DefaultValue(0)]
        public int? CountryId { get; set; }

        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }
        // Constructeur pour transformer un modèle Employee en DTO
        public EmployeeDtos() { }

        public EmployeeDtos(Employee employee)
        {
            EmployeeID = employee.EmployeeID;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            DateOfBirth = employee.DateOfBirth;
            Email = employee.Email;
            Phone = employee.Phone;
            Address = employee.Address;
            JobTitle = employee.JobTitle;
            DepartmentID = employee.DepartmentID;
            WorksID = employee.WorksID;
            CityID = employee.CityID;
            CountryId = employee.CountryId;
            StartDate = employee.StartDate;
            Salary = employee.Salary;
            CreatedAt = employee.CreatedAt;
            UpdatedAt = employee.UpdatedAt;
            IsAcitve = employee.IsAcitve;
        }
    }
}
