using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Employees;

[ApiController]
[Route("api/employees")]
[Tags("employees")]
public class EmployeesDeleteController : EmployeesController
{
    public EmployeesDeleteController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var employee = await services.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("employee deleted");
    }
}
