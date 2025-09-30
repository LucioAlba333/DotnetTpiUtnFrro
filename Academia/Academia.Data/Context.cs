using Academia.Models;
using Microsoft.EntityFrameworkCore;



namespace Academia.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Modulo> Modulos { get; set; }
    public DbSet<ModuloUsuario> ModuloUsuarios { get; set; }
    public DbSet<Materia> Materias { get; set; }
    
    public async Task InitDatabase()
    {
       await Database.EnsureCreatedAsync();
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
            entity.HasOne(e => e.Especialidad)
                .WithMany()
                .HasForeignKey(e => e.EspecialidadId);
            entity.HasData(
                new {Id=1, Descripcion = "Plan sistemas 2025", EspecialidadId = 1});
        });
        
        modelBuilder.Entity<Usuario>( entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.NombreUsuario)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Clave)
                .IsRequired()
                .HasMaxLength(300);
            entity.Property(e=> e.IdPersona)
                .IsRequired();
            entity.HasOne(e => e.Persona)
                .WithMany()
                .HasForeignKey(e => e.IdPersona);
            entity.HasIndex(e=> e.IdPersona)
                .IsUnique();
            entity.HasIndex(e=>e.NombreUsuario)
                .IsUnique();
        });
            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.HasData(
                    new {Id=1, Descripcion = "Especialidades"}, 
                    new {Id=2, Descripcion = "Planes"}
                    );
            });
        modelBuilder.Entity<ModuloUsuario>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.IdUsuario);
            entity.HasOne(e => e.Modulo)
                .WithMany()
                .HasForeignKey(e => e.IdModulo);
            entity.Property(e => e.Alta).IsRequired();
            entity.Property(e => e.Modificacion).IsRequired();
            entity.Property(e => e.Consulta).IsRequired();
            entity.Property(e=> e.Baja).IsRequired();
        });
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Apellido)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Telefono)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Legajo)
                .IsRequired();

            entity.Property(e => e.FechaNacimiento)
                .IsRequired();

            entity.Property(e => e.TipoPersona)
                .IsRequired()
                .HasConversion<int>(); 

            entity.HasOne(e => e.Plan)
                .WithMany()
                .HasForeignKey(e => e.IdPlan)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasIndex(e=> e.Email)
                .IsUnique();
            entity.HasIndex(e=> e.Legajo)
                .IsUnique();
            entity.HasData(new
            {
                Id = 1,
                Nombre = "admin",
                Apellido = "admin",
                Direccion = "xxx",
                Telefono = "xxx",
                Email = "admin@admin.com",
                Legajo = 1,
                FechaNacimiento = new DateTime(1995, 4, 12),
                TipoPersona = TipoPersona.Administrador, 
            });
        });
        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.HsSemanales)
                .IsRequired();
            entity.Property(e => e.HsTotales)
                .IsRequired();
            entity.HasOne(e => e.Plan)
                .WithMany()
                .HasForeignKey(e => e.IdPlan);
        });
    }
}