using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/bookings")]
[Tags("bookings")]
public class BookingsPutController : BookingsController
{
    public BookingsPutController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBooking(int id, Booking booking)
    {
        if (id != booking.Id)
        {
            return BadRequest();
        }
        await services.Update(booking);
        return Ok("booking updated");
    }
}
