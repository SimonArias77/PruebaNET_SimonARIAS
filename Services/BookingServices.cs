using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Data;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Services
{
    public class BookingServices : IBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Bookings.AnyAsync(b => b.Id == id);
        }

        public async Task Delete(int id)
        {
            var booking = await GetById(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Booking>> GetAll()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetById(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }

        public async Task Update(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}