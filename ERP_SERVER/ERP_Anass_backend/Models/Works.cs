using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Works
    { 
        public int WorkstID { get; set; }
        public string WorksName { get; set; }
        public int DepartmentID { get; set; }

        [JsonIgnore]
        public Department Department { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
