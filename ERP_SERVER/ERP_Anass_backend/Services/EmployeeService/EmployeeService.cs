using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.EmployeeRepo;

namespace ERP_Anass_backend.Services.EmployeeService
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public List<EmployeeDtos> GetEmployees()
        {
            var employees = _employeeRepo.GetEmployees();
            return employees.Select(e => new EmployeeDtos(e)).ToList();
        }

        public EmployeeDtos GetEmployeeById(int id)
        {
            var employee = _employeeRepo.GetEmployeeById(id);
            if (employee == null) return null;

            return new EmployeeDtos(employee);
        }

        public EmployeeDtos AddEmployee(EmployeeDtos employeeDto)
        {
            var employee = new Employee
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                DateOfBirth = employeeDto.DateOfBirth,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone,
                Address = employeeDto.Address,
                JobTitle = employeeDto.JobTitle,
                DepartmentID = employeeDto.DepartmentID,
                WorksID = employeeDto.WorksID,
                StartDate = employeeDto.StartDate,
                Salary = employeeDto.Salary,
                CreatedAt = employeeDto.CreatedAt,
                UpdatedAt = employeeDto.UpdatedAt
            };

            var newEmployee = _employeeRepo.AddEmployee(employee);
            return new EmployeeDtos(newEmployee);
        }

        public EmployeeDtos UpdateEmployee(int id, EmployeeDtos employeeDto)
        {
            var existingEmployee = _employeeRepo.GetEmployeeById(id);
            if (existingEmployee == null) return null;

            existingEmployee.FirstName = string.IsNullOrEmpty(existingEmployee.FirstName) ?employeeDto.FirstName:existingEmployee.FirstName;
            existingEmployee.LastName =  string.IsNullOrEmpty(existingEmployee.LastName) ?employeeDto.LastName:existingEmployee.LastName;
            existingEmployee.DateOfBirth =employeeDto.DateOfBirth;
            existingEmployee.Email = string.IsNullOrEmpty(existingEmployee.Email) ? employeeDto.Email : existingEmployee.Email;
            existingEmployee.Phone = string.IsNullOrEmpty(existingEmployee.Phone) ? employeeDto.Phone : existingEmployee.Phone;
            existingEmployee.Address = string.IsNullOrEmpty(existingEmployee.Address) ? employeeDto.Address : existingEmployee.Address;
            existingEmployee.JobTitle = string.IsNullOrEmpty(existingEmployee.JobTitle) ? employeeDto.JobTitle : existingEmployee.JobTitle;
            existingEmployee.DepartmentID =existingEmployee.DepartmentID == 0 ?employeeDto.DepartmentID:existingEmployee.DepartmentID;
            existingEmployee.WorksID =existingEmployee.WorksID == 0 ? employeeDto.WorksID:existingEmployee.WorksID;
            existingEmployee.StartDate = employeeDto.StartDate;
            existingEmployee.Salary = existingEmployee.Salary == 0 ? employeeDto.Salary : existingEmployee.Salary;
            existingEmployee.UpdatedAt = employeeDto.UpdatedAt;

            var updatedEmployee = _employeeRepo.UpdateEmployee(id, existingEmployee);
            return new EmployeeDtos(updatedEmployee);
        }

        public bool DeleteEmployee(int id)
        {
            return _employeeRepo.DeleteEmployee(id);
        }




        public List<Department> GetDepartments()
        {
            return _employeeRepo.GetDepartments();
        }

        public Department GetDepartmentById(int id)
        {
            return _employeeRepo.GetDepartmentById(id);
        }

        public Department AddDepartment(Department department)
        {
            return _employeeRepo.AddDepartment(department);
        }

        public Department UpdateDepartment(int id, Department department)
        {
            var existingDepartment = _employeeRepo.GetDepartmentById(id);
            if (existingDepartment == null) return null;

            existingDepartment.DepartmentName = department.DepartmentName;
            return _employeeRepo.UpdateDepartment(id, existingDepartment);
        }

        public bool DeleteDepartment(int id)
        {
            return _employeeRepo.DeleteDepartment(id);
        }
        public List<Works> GetWorkss()
        {
            return _employeeRepo.GetWorkss();
        }

        public Works GetWorksById(int id)
        {
            return _employeeRepo.GetWorksById(id);
        }

        public Works AddWorks(Works works)
        {
            return _employeeRepo.AddWorks(works);
        }

        public Works UpdateWorks(int id, Works works)
        {
            var existingWorks = _employeeRepo.GetWorksById(id);
            if (existingWorks == null) return null;

            existingWorks.WorksName = works.WorksName;
            existingWorks.DepartmentID = works.DepartmentID;

            return _employeeRepo.UpdateWorks(id, existingWorks);
        }

        public bool DeleteWorks(int id)
        {
            return _employeeRepo.DeleteWorks(id);
        }
    }
}
