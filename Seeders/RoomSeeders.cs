using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Controllers.v1.Rooms;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Seeders;

public class RoomSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasData(
               // Floor 1
            new Room { Id = 1, RoomNumber = "101", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOcupancyPersons = 1, Status = "Available" },
            new Room { Id = 2, RoomNumber = "102", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 3, RoomNumber = "103", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 4, RoomNumber = "104", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOcupancyPersons = 4, Status = "Available" },
            new Room { Id = 5, RoomNumber = "105", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOcupancyPersons = 1, Status = "Available" },
            new Room { Id = 6, RoomNumber = "106", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 7, RoomNumber = "107", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 8, RoomNumber = "108", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOcupancyPersons = 4, Status = "Available" },
            new Room { Id = 9, RoomNumber = "109", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOcupancyPersons = 1, Status = "Available" },
            new Room { Id = 10, RoomNumber = "110", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },

            // Floor 2
            new Room { Id = 11, RoomNumber = "201", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOcupancyPersons = 1, Status = "Available" },
            new Room { Id = 12, RoomNumber = "202", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 13, RoomNumber = "203", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 14, RoomNumber = "204", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOcupancyPersons = 4, Status = "Available" },
            new Room { Id = 15, RoomNumber = "205", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOcupancyPersons = 1, Status = "Available" },
            new Room { Id = 16, RoomNumber = "206", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOcupancyPersons = 2, Status = "Available" },
            new Room { Id = 17, RoomNumber = "207", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOcupancyPersons = 2, Status = "Available" }
        );
    }
}
