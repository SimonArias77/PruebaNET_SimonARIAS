using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Employees;

[ApiController]
[Route("api/employees")]
[Tags("employees")]
public class EmployeesPostController : EmployeesController
{
    public EmployeesPostController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddProduct(Employee employee)
    {
        await services.Add(employee);
        return Ok("employee created");
    }
}
