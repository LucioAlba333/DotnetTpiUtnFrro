using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class DocenteCursosService : IEntityService<DocenteCursosDto>
{
    private readonly DocenteCursosRepository _docenteCursosRepository;
    private readonly PersonaRepository _personaRepository;
    private readonly CursoRepository _cursoRepository;

    public DocenteCursosService(
        DocenteCursosRepository docenteCursosRepository,
        PersonaRepository personaRepository,
        CursoRepository cursoRepository)
    {
        _docenteCursosRepository = docenteCursosRepository;
        _personaRepository = personaRepository;
        _cursoRepository = cursoRepository;
    }

    public async Task New(DocenteCursosDto dto)
    {
        try
        {
            var docente = await _personaRepository.Get(dto.IdDocente);
            var curso = await _cursoRepository.Get(dto.IdCurso);

            if (docente == null || curso == null)
                throw new ArgumentException("El docente o el curso no existen");

          

            var docenteCurso = new DocenteCursos(dto.Id,curso, docente,dto.Cargo);
           

            await _docenteCursosRepository.Add(docenteCurso);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("Error al asignar docente al curso", e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _docenteCursosRepository.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception("Error al eliminar la asignación", e);
        }
    }

    public async Task<DocenteCursosDto?> Get(int id)
    {
        try
        {
            var entity = await _docenteCursosRepository.Get(id);
            if (entity == null)
                return null;

            return new DocenteCursosDto
            {
                Id = entity.Id,
                IdDocente = entity.IdDocente,
                IdCurso = entity.IdCurso,
                DocenteNombreCompleto = $"{entity.Docente.Nombre} {entity.Docente.Apellido}",
                CursoDescripcion = $"{entity.Curso.Materia.Descripcion} - {entity.Curso.AnioCalendario}",
                Cargo = entity.Cargo.ToString()
            };
        }
        catch (Exception e)
        {
            throw new Exception("Error al obtener la asignación", e);
        }
    }

    public async Task<IEnumerable<DocenteCursosDto>> GetAll()
    {
        try
        {
            var asignaciones = await _docenteCursosRepository.GetAll();
            return asignaciones.Select(dc => new DocenteCursosDto
            {
                Id = dc.Id,
                IdDocente = dc.IdDocente,
                IdCurso = dc.IdCurso,
                DocenteNombreCompleto = $"{dc.Docente.Nombre} {dc.Docente.Apellido}",
                CursoDescripcion = $"{dc.Curso.Materia.Descripcion} - {dc.Curso.AnioCalendario}",
                Cargo = dc.Cargo.ToString()
            });
        }
        catch (Exception e)
        {
            throw new Exception("Error al obtener las asignaciones", e);
        }
    }

    public async Task<bool> Update(DocenteCursosDto dto)
    {
        try
        {
            var docente = await _personaRepository.Get(dto.IdDocente);
            var curso = await _cursoRepository.Get(dto.IdCurso);

            if (docente == null || curso == null)
                throw new ArgumentException("El docente o el curso no existen");

           

            var docenteCurso = new DocenteCursos(dto.Id,curso, docente,dto.Cargo);

            return await _docenteCursosRepository.Update(docenteCurso);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("Error al actualizar la asignación", e);
        }
    }
}
