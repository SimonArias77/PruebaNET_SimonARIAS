using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SimónArias.Models;

[Table("rooms")]

public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_number")]
    [MaxLength(10)]
    [Required]
    public string? RoomNumber { get; set; }

    [Column("room_type_id")]
    [Required]
    public int RoomTypeId { get; set; }

    [Column("price_per_night")]
    [Required]
    public double PricePerNight { get; set; }

    [Column("availability")]
    [Required]
    public bool Availability { get; set; }

    [Column("max_ocupancy_persons")]
    [Required]
    public int MaxOcupancyPersons { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public RoomType? RoomType { get; set; }
    public int Floor { get; internal set; }
    public int Number { get; internal set; }
}
