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
    public DbSet<Comision> Comisiones {  get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<DocenteCursos>  DocenteCursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    
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
            entity.Property(e => e.IdPersona)
                .IsRequired();
            entity.HasOne(e => e.Persona)
                .WithOne()
                .HasForeignKey<Usuario>(e => e.IdPersona);
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
                    new {Id=2, Descripcion = "Planes"},
                    new {Id=3, Descripcion = "Usuarios"},
                    new {Id=4, Descripcion = "Personas"},
                    new {Id=5, Descripcion = "Materias"},
                    new {Id=6, Descripcion = "Comisiones"},
                    new {Id=7, Descripcion = "Cursos"},
                    new {Id=8, Descripcion = "DocentesCursos"},
                    new {Id=9, Descripcion = "Inscripciones"}
                    );
            });
            modelBuilder.Entity<ModuloUsuario>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Alta).IsRequired();
                entity.Property(e => e.Baja).IsRequired();
                entity.Property(e => e.Modificacion).IsRequired();
                entity.Property(e => e.Consulta).IsRequired();

                entity.HasOne(e => e.Usuario)
                    .WithMany(u => u.Permisos)
                    .HasForeignKey(e => e.IdUsuario) 
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Modulo)
                    .WithMany()
                    .HasForeignKey(e => e.IdModulo)
                    .OnDelete(DeleteBehavior.Cascade);
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
                Legajo = 1000,
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
        modelBuilder.Entity<Comision>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .IsRequired();
            entity.Property(e => e.AnioEspecialidad)
                .IsRequired();
            entity.HasOne(e =>e.Plan)
                .WithMany()
                .HasForeignKey(e => e.IdPlan);
        });
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id) 
                .ValueGeneratedOnAdd();
            entity.Property(e => e.AnioCalendario)
                .IsRequired();
            entity.Property(e => e.Cupo)
                .IsRequired();
            entity.HasOne(e => e.Materia)
                .WithMany()
                .HasForeignKey(e => e.IdMateria)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(e => e.Comision) 
                .WithMany()
                .HasForeignKey(e =>e.IdComision)
                .OnDelete(DeleteBehavior.Restrict);
        });
        modelBuilder.Entity<DocenteCursos>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Cargo)
                .IsRequired()
                .HasConversion<int>();
            entity.HasOne(e => e.Docente)
                .WithMany()
                .HasForeignKey(e =>e.IdDocente)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(e => e.Curso)
                .WithMany()
                .HasForeignKey(e => e.IdCurso)
                .OnDelete(DeleteBehavior.Cascade);
        });
        modelBuilder.Entity<Inscripcion>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Nota);
            entity.Property(e => e.Condicion);
            entity.HasOne(e => e.Alumno)
                .WithMany()
                .HasForeignKey(e => e.IdAlumno)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(e => e.Curso)
                .WithMany()
                .HasForeignKey(e => e.IdCurso)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}