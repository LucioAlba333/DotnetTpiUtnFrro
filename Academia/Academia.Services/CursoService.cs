using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class CursoService : IEntityService<CursoDto>
{
    private readonly CursoRepository _cursoRepository;
    private readonly MateriaRepository _materiaRepository;
    private readonly ComisionRepository _comisionRepository;

    public CursoService(
        CursoRepository cursoRepository,
        MateriaRepository materiaRepository,
        ComisionRepository comisionRepository)
    {
        _cursoRepository = cursoRepository;
        _materiaRepository = materiaRepository;
        _comisionRepository = comisionRepository;
    }

    public async Task New(CursoDto cursoDto)
    {
        try
        {
            var materia = await _materiaRepository.Get(cursoDto.IdMateria);
            var comision = await _comisionRepository.Get(cursoDto.IdComision);

            if (materia == null || comision == null)
                throw new ArgumentException("materia o comisión no existen");

            var curso = new Curso(
              cursoDto.Id,
              materia,
              comision,
              cursoDto.AnioCalendario,
              cursoDto.Cupo
            );

            await _cursoRepository.Add(curso);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("error al crear el curso", e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _cursoRepository.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception("error al eliminar el curso", e);
        }
    }

    public async Task<CursoDto?> Get(int id)
    {
        try
        {
            var curso = await _cursoRepository.Get(id);
            if (curso == null)
                return null;

            return new CursoDto
            {
                Id = curso.Id,
                AnioCalendario = curso.AnioCalendario,
                Cupo = curso.Cupo,
                IdMateria = curso.IdMateria,
                MateriaDescripcion = curso.Materia.Descripcion,
                IdComision = curso.IdComision,
                ComisionDescripcion = curso.Comision.Descripcion
            };
        }
        catch (Exception e)
        {
            throw new Exception("error al obtener el curso", e);
        }
    }

    public async Task<IEnumerable<CursoDto>> GetAll()
    {
        try
        {
            var cursos = await _cursoRepository.GetAll();
            return cursos.Select(c => new CursoDto
            {
                Id = c.Id,
                AnioCalendario = c.AnioCalendario,
                Cupo = c.Cupo,
                IdMateria = c.IdMateria,
                MateriaDescripcion = c.Materia.Descripcion,
                IdComision = c.IdComision,
                ComisionDescripcion = c.Comision.Descripcion
            });
        }
        catch (Exception e)
        {
            throw new Exception("error al obtener los cursos", e);
        }
    }

    public async Task<bool> Update(CursoDto cursoDto)
    {
        try
        {
            var materia = await _materiaRepository.Get(cursoDto.IdMateria);
            var comision = await _comisionRepository.Get(cursoDto.IdComision);

            if (materia == null || comision == null)
                throw new ArgumentException("materia o comisión no existen");

            var curso = new Curso(
                cursoDto.Id,
                materia,
                comision,
                cursoDto.AnioCalendario,
                cursoDto.Cupo
            );

            return await _cursoRepository.Update(curso);
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("error al actualizar el curso", e);
        }
    }
}
