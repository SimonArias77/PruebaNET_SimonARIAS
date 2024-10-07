using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SimónArias.Models;

[Table("room_types")]
public class RoomType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50)]
    [Required]
    public string? Name { get; set; }

    [Column("description")]
    [MaxLength(255)]
    public string? Description { get; set; }
    public int Capacity { get; internal set; }
    public int Price { get; internal set; }
}
