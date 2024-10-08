using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // Employee Endpoints
        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeService.GetEmployees();
            return Ok(employees);
        }
        // Employee Endpoints
        [HttpGet("GetEmployeesDetails")]
        public IActionResult GetEmployeesDetails()
        {
            var employees = _employeeService.GetEmployeesDetails();
            return Ok(employees);
        }
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
                return NotFound("Employee not found");
            return Ok(employee);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] EmployeeDtos employee)
        {
            var newEmployee = _employeeService.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = newEmployee.EmployeeID }, newEmployee);
        }

        [HttpPut("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeeDtos employee)
        {
            var updatedEmployee = _employeeService.UpdateEmployee(id, employee);
            if (updatedEmployee == null)
                return NotFound("Employee not found");
            return Ok(updatedEmployee);
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var deleted = _employeeService.DeleteEmployee(id);
            if (!deleted)
                return NotFound("Employee not found");
            return NoContent();
        }

        // Department Endpoints
        [HttpGet("GetDepartments")]
        public IActionResult GetDepartments()
        {
            var departments = _employeeService.GetDepartments();
            return Ok(departments);
        }

        [HttpGet("GetDepartmentById/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _employeeService.GetDepartmentById(id);
            if (department == null)
                return NotFound("Department not found");
            return Ok(department);
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment([FromBody] Department department)
        {
            var newDepartment = _employeeService.AddDepartment(department);
            return CreatedAtAction(nameof(GetDepartmentById), new { id = newDepartment.DepartmentID }, newDepartment);
        }

        [HttpPut("UpdateDepartment/{id}")]
        public IActionResult UpdateDepartment(int id, [FromBody] Department department)
        {
            var updatedDepartment = _employeeService.UpdateDepartment(id, department);
            if (updatedDepartment == null)
                return NotFound("Department not found");
            return Ok(updatedDepartment);
        }

        [HttpDelete("DeleteDepartment/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var deleted = _employeeService.DeleteDepartment(id);
            if (!deleted)
                return NotFound("Department not found");
            return NoContent();
        }

        // Works Endpoints
        [HttpGet("GetWorks")]
        public IActionResult GetWorks()
        {
            var works = _employeeService.GetWorkss();
            return Ok(works);
        }
        [HttpGet("GetWorksDetails")]
        public IActionResult GetWorksDetails()
        {
            var works = _employeeService.GetWorksDetails();
            return Ok(works);
        }
        [HttpGet("GetWorksDetailsByDepartment/{id}")]
        public IActionResult GetWorksDetailsByDepartment(int id)
        {
            var works = _employeeService.GetWorksDetailsByDepartment(id);
            return Ok(works);
        }
        [HttpGet("GetWorksById/{id}")]
        public IActionResult GetWorksById(int id)
        {
            var works = _employeeService.GetWorksById(id);
            if (works == null)
                return NotFound("Works not found");
            return Ok(works);
        }

        [HttpPost("AddWorks")]
        public IActionResult AddWorks([FromBody] Works works)
        {
            var newWorks = _employeeService.AddWorks(works);
            return CreatedAtAction(nameof(GetWorksById), new { id = newWorks.WorkstID }, newWorks);
        }

        [HttpPut("UpdateWorks/{id}")]
        public IActionResult UpdateWorks(int id, [FromBody] Works works)
        {
            var updatedWorks = _employeeService.UpdateWorks(id, works);
            if (updatedWorks == null)
                return NotFound("Works not found");
            return Ok(updatedWorks);
        }

        [HttpDelete("DeleteWorks/{id}")]
        public IActionResult DeleteWorks(int id)
        {
            var deleted = _employeeService.DeleteWorks(id);
            if (!deleted)
                return NotFound("Works not found");
            return NoContent();
        }
    }
}
