using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation(
            Summary = "Get all room types",
            Description = "Retrieves a list of all available room types."
        )]
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
    [SwaggerOperation(
            Summary = "Get room type by ID",
            Description = "Retrieves a room type record based on the provided room type ID."
        )]
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
