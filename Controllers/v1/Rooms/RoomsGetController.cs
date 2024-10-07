using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Rooms;

[ApiController]
[Route("api/rooms")]
[Tags("rooms")]
public class RoomsGetController : RoomsController
{
    public RoomsGetController(IRoomRepository roomRepository) : base(roomRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRooms()
    {
        var rooms = await services.GetAll();
        if (rooms == null || !rooms.Any())
        {
            return NoContent();
        }
        return Ok(rooms);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoomById(int id)
    {
        var room = await services.GetById(id);
        if (room == null)
        {
            return NotFound();
        }
        return Ok(room);
    }
}
