using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CokoladaEF.Models;

public partial class ChocolateDbContext : DbContext
{
    public ChocolateDbContext()
    {
    }

    public ChocolateDbContext(DbContextOptions<ChocolateDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChocolateType> ChocolateTypes { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=chocolateDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChocolateType>(entity =>
        {
            entity.ToTable("ChocolateType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Ingredient1).HasColumnName("ingredient");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
