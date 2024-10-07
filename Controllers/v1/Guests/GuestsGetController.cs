using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsGetController : GuestsController
{
    public GuestsGetController(IGuestRepository guestRepository) : base(guestRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllGuests()
    {
        var guests = await services.GetAll();
        if (guests == null || !guests.Any())
        {
            return NoContent();
        }
        return Ok(guests);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGuestById(int id)
    {
        var guest = await services.GetById(id);
        if (guest == null)
        {
            return NotFound();
        }
        return Ok(guest);
    }
}
