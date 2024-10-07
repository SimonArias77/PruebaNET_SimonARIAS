using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

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
