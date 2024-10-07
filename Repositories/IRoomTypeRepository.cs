using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Repositories;

public interface IRoomTypeRepository
{
    Task<IEnumerable<RoomType>> GetAll();
    Task<RoomType> GetById(int id);
    Task Add(RoomType roomType);
    Task Update(RoomType roomType);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
