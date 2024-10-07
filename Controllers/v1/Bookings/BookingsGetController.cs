using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/bookings")]
[Tags("bookings")]
public class BookingsGetController : BookingsController
{
    public BookingsGetController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpGet]
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

