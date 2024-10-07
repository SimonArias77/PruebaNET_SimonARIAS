using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Repositories;

public interface IBookingRepository
{
    Task<IEnumerable<Booking>> GetAll();
    Task<Booking> GetById(int id);
    Task Add(Booking booking);
    Task Update(Booking booking);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
