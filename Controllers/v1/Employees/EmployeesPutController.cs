using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Employees;

[ApiController]
[Route("api/employees")]
[Tags("employees")]
public class EmployeesPutController : EmployeesController
{
    public EmployeesPutController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }
        await services.Update(employee);
        return Ok("employee updated");
    }
}

