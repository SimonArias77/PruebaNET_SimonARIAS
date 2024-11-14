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
[Route("api/booking_delete")]
[Tags("bookings")]
public class BookingsDeleteController : BookingController
{

    //constructor
    public BookingsDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpDelete]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Delete a booking",
            Description = "Deletes a specified booking record by its ID."
        )]
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
