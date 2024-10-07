using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Repositories;

public interface IGuestRepository
{
    Task<IEnumerable<Guest>> GetAll();
    Task<Guest> GetById(int id);
    Task<Guest> GetByEmail(string? email);
    Task Add(Guest guest);
    Task Update(Guest guest);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
