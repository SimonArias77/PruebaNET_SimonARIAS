using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/bookings")]
[Tags("bookings")]
public class BookingsDeleteController : BookingsController
{
    public BookingsDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var booking = await services.GetById(id);
        if (booking == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("booking deleted");
    }


}
