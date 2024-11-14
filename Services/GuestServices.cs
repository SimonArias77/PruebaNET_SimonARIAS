using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Data;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Services;

public class GuestServices(ApplicationDbContext context) : IGuestRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task Add(Guest guest)
    {
        await _context.Guests.AddAsync(guest);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Guests.AnyAsync(g => g.Id == id);
    }

    public async Task Delete(int id)
    {
        var guest = await GetById(id);
        if (guest != null)
        {
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Guest>> GetAll()
    {
        return await _context.Guests.ToListAsync();
    }

    public async Task<Guest> GetByEmail(string? email)
    {
        return await _context.Guests.FirstOrDefaultAsync(g => g.Email == email);
    }

    public async Task<Guest> GetById(int id)
    {
        return await _context.Guests.FindAsync(id);
    }

    public async Task<IEnumerable<Guest>> GetByKeyword(string keyword)
    {
        return await _context.Guests.Where(g => g.FirstName.Contains(keyword) || g.LastName.Contains(keyword)).ToListAsync();
    }

    public async Task Update(Guest guest)
    {
        _context.Entry(guest).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
