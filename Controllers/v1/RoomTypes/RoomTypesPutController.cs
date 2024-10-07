using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.RoomTypes;

[ApiController]
[Route("api/v1/room_types")]
[Tags("room_types")]
public class RoomTypesPutController : RoomTypesController
{
    public RoomTypesPutController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRoomType(int id, RoomType roomType)
    {
        if (id != roomType.Id)
        {
            return BadRequest();
        }
        await services.Update(roomType);
        return Ok("room type updated");
    }
}
