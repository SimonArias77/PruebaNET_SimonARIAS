using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsDeleteController : GuestsController
{
    public GuestsDeleteController(IGuestRepository guestRepository) : base(guestRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteGuest(int id)
    {
        var guest = await services.GetById(id);
        if (guest == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("guest deleted");
    }
}
