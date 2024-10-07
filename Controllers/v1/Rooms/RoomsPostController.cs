using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Rooms;

[ApiController]
[Route("api/rooms")]
[Tags("rooms")]
public class RoomsPostController : RoomsController
{
    public RoomsPostController(IRoomRepository roomRepository) : base(roomRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddRoom(Room room)
    {
        await services.Add(room);
        return Ok("room created");
    }
}

