using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Guests;

[ApiController]
[Route("api/guests")]
public class GuestsController : ControllerBase
{
    protected readonly IGuestRepository services;
    public GuestsController(IGuestRepository guestRepository)
    {
        services = guestRepository;
    }
}
