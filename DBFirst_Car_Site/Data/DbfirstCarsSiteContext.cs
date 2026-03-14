using System;
using System.Collections.Generic;
using DBFirst_Car_Site.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_Car_Site.Data;

public partial class DbfirstCarsSiteContext : DbContext
{
    public DbfirstCarsSiteContext()
    {
    }

    public DbfirstCarsSiteContext(DbContextOptions<DbfirstCarsSiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Cat).WithMany(p => p.Cars).HasConstraintName("FK_Cars_Categories");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83F6D632D0B");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
