using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Data;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Services;

public class RoomTypeServices : IRoomTypeRepository
{
    private readonly ApplicationDbContext _context;

    public RoomTypeServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Add(RoomType roomType)
    {
        await _context.RoomTypes.AddAsync(roomType);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.RoomTypes.AnyAsync(r => r.Id == id);
    }

    public async Task Delete(int id)
    {
        var roomType = await GetById(id);
        if (roomType != null)
        {
            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<RoomType>> GetAll()
    {
        return await _context.RoomTypes.ToListAsync();
    }

    public async Task<RoomType> GetById(int id)
    {
        return await _context.RoomTypes.FindAsync(id);
    }

    public async Task Update(RoomType roomType)
    {
        _context.Entry(roomType).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
