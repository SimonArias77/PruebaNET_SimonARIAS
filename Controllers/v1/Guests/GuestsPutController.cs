using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_SimónArias.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsPutController : GuestsController
{
    public GuestsPutController(IGuestRepository guestRepository) : base(guestRepository)
    {
    }

    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Update guest information",
            Description = "Updates the details of an existing guest identified by the provided ID."
        )]
    public async Task<IActionResult> UpdateCustomer(int id, Guest guest)
    {
        if (id != guest.Id)
        {
            return BadRequest();
        }
        await services.Update(guest);
        return Ok("guest updated");
    }
}
