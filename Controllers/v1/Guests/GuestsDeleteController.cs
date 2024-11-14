using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation(
            Summary = "Delete a guest",
            Description = "Deletes a guest record identified by the provided ID."
        )]
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
