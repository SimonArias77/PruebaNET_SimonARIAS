using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/booking_post")]
[Tags("bookings")]
public class BookingsPostController : BookingController
{
    public BookingsPostController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpPost]
    // [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
            Summary = "Create a new booking",
            Description = "Creates a new booking record for a specified room and guest, ensuring all provided data is valid."
        )]
    public async Task<IActionResult> AddOrderProduct(Booking booking)
    {
        await services.Add(booking);
        return Ok("booking created");
    }
}
