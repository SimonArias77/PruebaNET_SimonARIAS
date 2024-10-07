using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Rooms;

[ApiController]
[Route("api/rooms")]
[Tags("rooms")]
public class RoomsPutController : RoomsController
{
    public RoomsPutController(IRoomRepository roomRepository) : base(roomRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRoom(int id, Room room)
    {
        if (id != room.Id)
        {
            return BadRequest();
        }
        await services.Update(room);
        return Ok("room updated");
    }
}
