using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.EmployeeRepo
{
    public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);


        List<Department> GetDepartments();
        Department GetDepartmentById(int id);
        Department AddDepartment(Department Department);
        Department UpdateDepartment(int id, Department Department);
        bool DeleteDepartment(int id);

        List<Works> GetWorkss();
        Works GetWorksById(int id);
        Works AddWorks(Works Works);
        Works UpdateWorks(int id, Works Works);
        bool DeleteWorks(int id);
    }
}
