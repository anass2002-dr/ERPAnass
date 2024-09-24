using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        [JsonIgnore]
        public ICollection<Works> Work { get; set; } = new List<Works>();
        [JsonIgnore]
        public ICollection<Employee> Employees{ get; set; } = new List<Employee>();
    }
}
