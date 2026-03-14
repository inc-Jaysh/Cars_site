using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_Car_Site.Models;

public partial class Category
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("description")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("max_seats")]
    public int? MaxSeats { get; set; }

    [InverseProperty("Cat")]
    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
