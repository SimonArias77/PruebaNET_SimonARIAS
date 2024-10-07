using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Employees;

[ApiController]
[Route("api/employees")]
public class EmployeesController : ControllerBase
{
    protected readonly IEmployeeRepository services;
    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        services = employeeRepository;
    }
}
