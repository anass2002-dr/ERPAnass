using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<EmployeeDtos> GetEmployees();
        EmployeeDtos GetEmployeeById(int id);
        EmployeeDtos AddEmployee(EmployeeDtos employee);
        EmployeeDtos UpdateEmployee(int id, EmployeeDtos employee);
        bool DeleteEmployee(int id);


        List<Department> GetDepartments();
        Department GetDepartmentById(int id);
        Department AddDepartment(Department Department);
        Department UpdateDepartment(int id, Department Department);
        bool DeleteDepartment(int id);

        List<Works> GetWorkss();
        Works GetWorksById(int id);
        List<dynamic> GetWorksDetails();
        Works AddWorks(Works Works);
        Works UpdateWorks(int id, Works Works);
        bool DeleteWorks(int id);


    }
}
