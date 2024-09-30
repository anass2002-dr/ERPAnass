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
                CityID = employeeDto.CityID,
                CountryId = employeeDto.CountryId,
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

            existingEmployee.FirstName = string.IsNullOrEmpty(employeeDto.FirstName) ? existingEmployee.FirstName: employeeDto.FirstName;
            existingEmployee.LastName =  string.IsNullOrEmpty(employeeDto.LastName) ? existingEmployee.LastName: employeeDto.LastName;
            existingEmployee.DateOfBirth = employeeDto.DateOfBirth;
            existingEmployee.Email = string.IsNullOrEmpty(employeeDto.Email) ? existingEmployee.Email : employeeDto.Email;
            existingEmployee.Phone = string.IsNullOrEmpty(employeeDto.Phone) ? existingEmployee.Phone : employeeDto.Phone;
            existingEmployee.Address = string.IsNullOrEmpty(employeeDto.Address) ? existingEmployee.Address : employeeDto.Address;
            existingEmployee.JobTitle = string.IsNullOrEmpty(employeeDto.JobTitle) ? existingEmployee.JobTitle : employeeDto.JobTitle;
            existingEmployee.DepartmentID = employeeDto.DepartmentID == 0 ? existingEmployee.DepartmentID: employeeDto.DepartmentID;
            existingEmployee.WorksID = employeeDto.WorksID == 0 ? existingEmployee.WorksID: employeeDto.WorksID;
            existingEmployee.CityID = employeeDto.CityID == 0 ? existingEmployee.CityID: employeeDto.CityID;
            existingEmployee.CountryId = employeeDto.CountryId == 0 ? existingEmployee.CountryId: employeeDto.CountryId;
            existingEmployee.StartDate = employeeDto.StartDate;
            existingEmployee.Salary = employeeDto.Salary == 0 ? existingEmployee.Salary : employeeDto.Salary;
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
        public List<dynamic> GetWorksDetails()
        {
            return _employeeRepo.GetWorksDetails();
        }
        public List<dynamic> GetWorksDetailsByDepartment(int id)
        {
            return _employeeRepo.GetWorksDetailsByDepartment(id);
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
            existingWorks.DepartmentID = works.DepartmentID==0?existingWorks.DepartmentID: works.DepartmentID;

            return _employeeRepo.UpdateWorks(id, existingWorks);
        }

        public bool DeleteWorks(int id)
        {
            return _employeeRepo.DeleteWorks(id);
        }
    }
}
