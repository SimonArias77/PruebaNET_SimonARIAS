using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.RoomTypes;

[ApiController]
[Route("api/v1/room_types")]
[Tags("room_types")]
public class RoomTypesPostController : RoomTypesController
{
    public RoomTypesPostController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddRoomType(RoomType roomType)
    {
        await services.Add(roomType);
        return Ok("roomtype created");
    }
}
