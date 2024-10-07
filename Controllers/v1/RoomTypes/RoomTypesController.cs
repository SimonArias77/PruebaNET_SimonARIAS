using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.RoomTypes;

[ApiController]
[Route("api/roomTypes")]
public class RoomTypesController : ControllerBase
{
    protected readonly IRoomTypeRepository services;
    public RoomTypesController(IRoomTypeRepository roomTypeRepository)
    {
        services = roomTypeRepository;
    }
}
