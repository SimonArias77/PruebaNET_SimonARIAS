using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.RoomTypes;

[ApiController]
[Route("api/v1/room_types")]
[Tags("room_types")]
public class RoomTypesDeleteController : RoomTypesController
{
    public RoomTypesDeleteController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteRoomType(int id)
    {
        var roomType = await services.GetById(id);
        if (roomType == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("room type deleted");
    }
}
