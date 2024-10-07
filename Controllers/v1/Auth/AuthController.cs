using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Config;
using PruebaNET_SimónArias.DTOs.Requests;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

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

    // method to generate a jwt
    [HttpPost]
    public async Task<IActionResult> GenerateToken(Employee employee)
    {
        var token = JWT.GenerateJwtToken(employee);

        return Ok($"acá está su token: {token}");
    }

    [HttpPost]
    [Route("login")]
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

    [HttpPost]
    [Route("register")]
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
