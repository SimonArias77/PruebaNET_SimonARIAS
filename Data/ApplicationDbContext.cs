using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Seeders;


namespace PruebaNET_SimónArias.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    // Properties of ApplicationDbContext to reference our Model classes.

    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }

    // Constructor of ApplicationDbContext.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        RoomSeeders.Seed(modelBuilder);
        RoomTypeSeeder.Seed(modelBuilder);

        modelBuilder.Entity<Guest>()
            .HasIndex(g => g.IdentificationNumber)
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.IdentificationNumber)
            .IsUnique();
    }
}


