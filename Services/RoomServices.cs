using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Data;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Services;

public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;
    public async Task Add(Room room)
    {
        await _context.Rooms.AddAsync(room);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Rooms.AnyAsync(r => r.Id == id);
    }

    public async Task Delete(int id)
    {
        var room = await GetById(id);
        if (room != null)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Room>> GetAll()
    {
        return await _context.Rooms.ToListAsync();
    }

    public async Task<Room> GetById(int id)
    {
        return await _context.Rooms.FindAsync(id);
    }

    public async Task Update(Room room)
    {
        _context.Entry(room).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
