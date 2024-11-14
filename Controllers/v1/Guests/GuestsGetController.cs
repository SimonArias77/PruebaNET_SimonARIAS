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
public class GuestsGetController : GuestsController
{
    public GuestsGetController(IGuestRepository guestRepository) : base(guestRepository)
    {
    }

    [HttpGet]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get all guests",
            Description = "Retrieves a list of all registered guests."
        )]
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
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get guest by ID",
            Description = "Retrieves a guest record based on the provided guest ID."
        )]
    public async Task<IActionResult> GetGuestById(int id)
    {
        var guest = await services.GetById(id);
        if (guest == null)
        {
            return NotFound();
        }
        return Ok(guest);
    }

    [HttpGet("{keyword}")] // Specifies the HTTP GET method for searching guests by keyword
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Search guests by keyword",
            Description = "Retrieves a list of guests matching the provided search keyword."
        )]
    public async Task<ActionResult<IEnumerable<Guest>>> SearchByKeyword(string keyword)
    {
        // Call the repository to find guests by the specified keyword
        var guests = await services.GetByKeyword(keyword);
        return Ok(guests); // Return the list of matching guests
    }
}
