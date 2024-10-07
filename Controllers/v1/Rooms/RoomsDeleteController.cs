using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Rooms;

[ApiController]
[Route("api/rooms")]
[Tags("rooms")]
public class RoomsDeleteController : RoomsController
{
    public RoomsDeleteController(IRoomRepository roomRepository) : base(roomRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteRoom(int id)
    {
        var room = await services.GetById(id);
        if (room == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("room deleted");
    }

}
