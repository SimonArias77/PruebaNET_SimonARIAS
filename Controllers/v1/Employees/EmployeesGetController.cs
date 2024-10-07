using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Employees;

[ApiController]
[Route("api/employees")]
[Tags("employees")]
public class EmployeesGetController : EmployeesController
{
    public EmployeesGetController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await services.GetAll();
        if (employees == null || !employees.Any())
        {
            return NoContent();
        }
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await services.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }
}
