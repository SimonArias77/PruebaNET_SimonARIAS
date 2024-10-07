using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.RoomTypes;

[ApiController]
[Route("api/v1/room_types")]
[Tags("room_types")]
public class RoomTypesGetController : RoomTypesController
{
    public RoomTypesGetController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRoomTypes()
    {
        var roomTypes = await services.GetAll();
        if (roomTypes == null || !roomTypes.Any())
        {
            return NoContent();
        }
        return Ok(roomTypes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoomTypeById(int id)
    {
        var roomType = await services.GetById(id);
        if (roomType == null)
        {
            return NotFound();
        }
        return Ok(roomType);
    }

}
