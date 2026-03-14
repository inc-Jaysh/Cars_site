using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_Car_Site.Models;

public partial class Car
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("brand")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Brand { get; set; }

    [Column("model")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("speed")]
    public int? Speed { get; set; }

    [Column("weight")]
    public int? Weight { get; set; }

    [Column("price")]
    public int? Price { get; set; }

    [Column("year")]
    public DateOnly? Year { get; set; }

    [Column("cat_id")]
    public int? CatId { get; set; }

    [ForeignKey("CatId")]
    [InverseProperty("Cars")]
    public virtual Category? Cat { get; set; }
}
