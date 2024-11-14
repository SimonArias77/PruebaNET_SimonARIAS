using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/booking_get")]
[Tags("bookings")]
public class BookingGetController : BookingController
{
    public BookingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
            Summary = "Get booking",
            Description = "Retrieves a booking record"
        )]
    public async Task<IActionResult> GetAllBookings()
    {
        var bookings = await services.GetAll();
        if (bookings == null || !bookings.Any())
        {
            return NoContent();
        }
        return Ok(bookings);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get booking by ID",
            Description = "Retrieves a booking record based on the provided booking ID."
        )]
    public async Task<IActionResult> GetBookingById(int id)
    {
        var booking = await services.GetById(id);
        if (booking == null)
        {
            return NotFound();
        }
        return Ok(booking);
    }
}

