using Academia.Models;
using Microsoft.EntityFrameworkCore;
namespace Academia.Data;

public class Context : DbContext
{
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Plan> Planes { get; set; }

    public void InitDatabase()
    {
        this.Database.EnsureCreated();
    }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
            entity.HasIndex(e => e.Descripcion)
                .IsUnique();
            entity.HasData(
                new {Id=1, Descripcion = "Sistemas"});
        });
        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
            entity.HasIndex(e => e.Descripcion)
                .IsUnique();
            entity.Property(e => e.EspecialidadId)
                .IsRequired();
            modelBuilder.Entity<Plan>()
                .HasOne(p => p.Especialidad)
                .WithMany()
                .HasForeignKey(p => p.EspecialidadId);
            entity.HasData(
                new {Id=1, Descripcion = "Plan sistemas 2025", EspecialidadId = 1});

        });
    }
}