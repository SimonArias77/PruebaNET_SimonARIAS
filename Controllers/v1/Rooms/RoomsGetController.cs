using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

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
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get all rooms",
            Description = "Retrieves a list of all available rooms."
    )]
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
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get room by ID",
            Description = "Retrieves a room record based on the provided room ID."
        )]
    public async Task<IActionResult> GetRoomById(int id)
    {
        var room = await services.GetById(id);
        if (room == null)
        {
            return NotFound();
        }
        return Ok(room);
    }

    [HttpGet("/api/v1/rooms/status")] // Specifies the HTTP GET method for retrieving room status
    [SwaggerOperation(
            Summary = "Get room status",
            Description = "Retrieves the current status of all rooms."
        )]
    public async Task<ActionResult<object>> GetStatus()
    {
        // Call the repository to get room status
        var status = await services.GetStatus();
        if (status == null)
        {
            return NotFound("No hay habitaciones"); // Return NotFound if no rooms are available
        }
        return Ok(status); // Return the status of the rooms
    }

    [HttpGet("/api/v1/rooms/available")] // Specifies the HTTP GET method for retrieving available rooms
    [SwaggerOperation(
        Summary = "Get available rooms",
        Description = "Retrieves a list of all currently available rooms."
    )]
    public async Task<ActionResult<IEnumerable<Room>>> GetAvailable()
    {
        // Call the repository to get available rooms
        var rooms = await services.GetAvailable();
        return Ok(rooms); // Return the list of available rooms
    }

    [HttpGet("/api/v1/rooms/occupied")] // Specifies the HTTP GET method for retrieving occupied rooms
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
        Summary = "Get occupied rooms",
        Description = "Retrieves a list of all currently occupied rooms."
    )]
    public async Task<ActionResult<IEnumerable<Room>>> GetOccupied()
    {
        // Call the repository to get occupied rooms
        var rooms = await services.GetOccupied();
        return Ok(rooms); // Return the list of occupied rooms
    }
}
