using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Rooms;

[ApiController]
[Route("api/rooms")]
public class RoomsController : ControllerBase
{
    protected readonly IRoomRepository services;
    public RoomsController(IRoomRepository roomRepository)
    {
        services = roomRepository;
    }
}
