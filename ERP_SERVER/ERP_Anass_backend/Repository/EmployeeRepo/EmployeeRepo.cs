using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.EmployeeRepo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DbContextERP _context;

        public EmployeeRepo(DbContextERP context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.Include(e => e.Department).Include(e => e.Works).ToList();
        }

        public List<dynamic> GetEmployeesDetails()
        {
            return _context.Employees.
                Include(co => co.Country).
                Include(ct=>ct.City).
                Include(dp=>dp.Department).
                Include(wk => wk.Works).Select(st => new
                {
                    st.EmployeeID,
                    st.FirstName,
                    st.LastName,
                    st.Phone,
                    st.Address,
                    st.Email,
                    st.Salary,
                    st.CityID,
                    st.CreatedAt,
                    st.UpdatedAt,
                    st.JobTitle,
                    st.CountryId,
                    st.WorksID,
                    st.StartDate,
                    st.DateOfBirth,
                    st.Country.CountryName,
                    st.City.CityName,
                    st.Works.WorksName,
                    st.Department.DepartmentName
                }
                
                ).ToList<dynamic>();
        }
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Include(e => e.Department).Include(e => e.Works)
                .FirstOrDefault(e => e.EmployeeID == id);
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            var existingEmployee = _context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Email = employee.Email;
                existingEmployee.Phone = employee.Phone;
                existingEmployee.Address = employee.Address;
                existingEmployee.JobTitle = employee.JobTitle;
                existingEmployee.DepartmentID = employee.DepartmentID;
                existingEmployee.WorksID = employee.WorksID;
                existingEmployee.CityID = employee.CityID;
                existingEmployee.CountryId = employee.CountryId;
                existingEmployee.StartDate = employee.StartDate;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.UpdatedAt = employee.UpdatedAt;

                _context.SaveChanges();
            }

            return existingEmployee;
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null) return false;
            try
            {

                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }



        public List<Department> GetDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.DepartmentID == id);
        }

        public Department AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public Department UpdateDepartment(int id, Department department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentID == id);
            if (existingDepartment != null)
            {
                existingDepartment.DepartmentName = department.DepartmentName;
                _context.SaveChanges();
            }
            return existingDepartment;
        }

        public bool DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.DepartmentID == id);
            if (department == null) return false;
            try
            {

                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public List<Works> GetWorkss()
        {
            return _context.Works.ToList();
        }
        public List<dynamic> GetWorksDetails()
        {
            return _context.Works.Include(c => c.Department)
                .Select(c => new
                {
                    c.WorkstID,
                    c.WorksName,
                    c.DepartmentID,
                    DepartmentName = c.Department.DepartmentName
                }).ToList<dynamic>();
        }
        public List<dynamic> GetWorksDetailsByDepartment(int id)
        {
            return _context.Works
                .Where(c => c.DepartmentID == id)
                .Include(c => c.Department)
                .Select(c => new
                {
                    c.WorkstID,
                    c.WorksName,
                    c.DepartmentID,
                    DepartmentName = c.Department.DepartmentName
                }).ToList<dynamic>();
        }
        public Works GetWorksById(int id)
        {
            return _context.Works.FirstOrDefault(w => w.WorkstID == id);
        }

        public Works AddWorks(Works works)
        {
            _context.Works.Add(works);
            _context.SaveChanges();
            return works;
        }

        public Works UpdateWorks(int id, Works works)
        {
            var existingWorks = _context.Works.FirstOrDefault(w => w.WorkstID == id);
            if (existingWorks != null)
            {
                existingWorks.WorksName = works.WorksName;
                existingWorks.DepartmentID = works.DepartmentID;
                _context.SaveChanges();
            }
            return existingWorks;
        }

        public bool DeleteWorks(int id)
        {
            var works = _context.Works.FirstOrDefault(w => w.WorkstID == id);
            if (works == null) return false;

            try
            {
                _context.Works.Remove(works);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
