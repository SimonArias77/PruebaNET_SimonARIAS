using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsPostController : GuestsController
{
    public GuestsPostController(IGuestRepository guestRepository) : base(guestRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddCustomer(Guest guest)
    {
        await services.Add(guest);
        return Ok("guest created");
    }
}
