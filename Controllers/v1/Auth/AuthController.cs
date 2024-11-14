using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Config;
using PruebaNET_SimónArias.DTOs.Requests;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_SimónArias.Controllers.v1.Auth;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    protected readonly IEmployeeRepository services;

    public AuthController(IEmployeeRepository employeeRepository)
    {
        services = employeeRepository;
    }

   

    [HttpPost("login")]
    [SwaggerOperation(
            Summary = "Employee login",
            Description = "Authenticates an employee using their email and password, returning a JWT token if successful."
        )]
    public async Task<IActionResult> Login(LoginDto data)
    {
        var employee = await services.GetByEmail(data.Email);

        if (employee == null)
            return BadRequest("el usuario no existe");

        if (employee.Password != data.Password)
            return BadRequest("contraseña incorrecta");

        var token = JWT.GenerateJwtToken(employee);

        return Ok($"acá está su token: {token}");
    }

    [HttpPost("register")]
    [SwaggerOperation(
            Summary = "Register a new employee",
            Description = "Creates a new employee record after validating the provided information and ensuring the email is not already in use."
        )]
    public async Task<IActionResult> Register(RegisterDto data)
    {
        var employee = await services.GetByEmail(data.Email);

        if (employee != null)
            return BadRequest("el email ya está registrado");

        employee = new Employee
        {
            FirstName = data.FirstName,
            LastName = data.LastName,
            Email = data.Email,
            IdentificationNumber = data.IdentificationNumber,
            Password = data.Password
        };

        await services.Add(employee);

        return Ok("Usuario registrado correctamente");
    }
}
