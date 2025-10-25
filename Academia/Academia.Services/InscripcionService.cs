using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class InscripcionService : IEntityService<InscripcionDto>
{
    private readonly InscripcionRepository _inscripcionRepository;
    private readonly PersonaRepository _personaRepository;
    private readonly CursoRepository _cursoRepository;

    public InscripcionService(
        InscripcionRepository inscripcionRepository,
        PersonaRepository personaRepository,
        CursoRepository cursoRepository)
    {
        _inscripcionRepository = inscripcionRepository;
        _personaRepository = personaRepository;
        _cursoRepository = cursoRepository;
    }

    public async Task New(InscripcionDto dto)
    {
        try
        {
            var alumno = await _personaRepository.Get(dto.IdAlumno);
            var curso = await _cursoRepository.Get(dto.IdCurso);

            if (alumno == null || curso == null)
                throw new ArgumentException("El alumno o el curso no existen");

            var inscripcion = new Inscripcion(
                dto.Id,
                alumno,
                curso,
                dto.Condicion,
                dto.Nota
            );

            await _inscripcionRepository.Add(inscripcion);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("Error al inscribir al alumno", e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _inscripcionRepository.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception("Error al eliminar la inscripción", e);
        }
    }

    public async Task<InscripcionDto?> Get(int id)
    {
        try
        {
            var entity = await _inscripcionRepository.Get(id);
            if (entity == null)
                return null;

            return new InscripcionDto
            {
                Id = entity.Id,
                IdAlumno = entity.IdAlumno,
                IdCurso = entity.IdCurso,
                NombreAlumno = $"{entity.Alumno.Nombre} {entity.Alumno.Apellido}",
                Condicion = entity.Condicion,
                Nota = entity.Nota
            };
        }
        catch (Exception e)
        {
            throw new Exception("Error al obtener la inscripción", e);
        }
    }

    public async Task<IEnumerable<InscripcionDto>> GetAll()
    {
        try
        {
            var inscripciones = await _inscripcionRepository.GetAll();
            return inscripciones.Select(i => new InscripcionDto
            {
                Id = i.Id,
                IdAlumno = i.IdAlumno,
                IdCurso = i.IdCurso,
                NombreAlumno = $"{i.Alumno.Nombre} {i.Alumno.Apellido}",
                Condicion = i.Condicion,
                Nota = i.Nota
            });
        }
        catch (Exception e)
        {
            throw new Exception("Error al obtener las inscripciones", e);
        }
    }

    public async Task<bool> Update(InscripcionDto dto)
    {
        try
        {
            var alumno = await _personaRepository.Get(dto.IdAlumno);
            var curso = await _cursoRepository.Get(dto.IdCurso);

            if (alumno == null || curso == null)
                throw new ArgumentException("El alumno o el curso no existen");

            var inscripcion = new Inscripcion(
                dto.Id,
                alumno,
                curso,
                dto.Condicion,
                dto.Nota
            );

            return await _inscripcionRepository.Update(inscripcion);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("Error al actualizar la inscripción", e);
        }
    }
}
