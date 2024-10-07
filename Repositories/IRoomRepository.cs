using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Repositories;

public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAll();
    Task<Room> GetById(int id);
    Task Add(Room room);
    Task Update(Room room);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}

