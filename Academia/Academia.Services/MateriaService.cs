using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class MateriaService : IEntityService<MateriaDto>
{
    private readonly MateriaRepository  _materiaRepository;
    private readonly PlanRepository _planRepository;

    public MateriaService(MateriaRepository materiaRepository, PlanRepository planRepository)
    {
        _materiaRepository = materiaRepository;
        _planRepository = planRepository;
    }

    public async Task New(MateriaDto dto)
    {
        try
        {
            Plan? plan = await _planRepository.Get(dto.IdPlan);
            if (plan != null)
            {
                Materia materia = new Materia(
                    dto.Id,
                    dto.Descripcion,
                    dto.HsSemanales,
                    dto.HsTotales,
                    plan);
                await _materiaRepository.Add(materia);
            }
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al crear materia",e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _materiaRepository.Delete(id);

        }
        catch (Exception e)
        {
            throw new ApplicationException("error al eliminar materia", e);
        }
    }

    public async Task<MateriaDto?> Get(int id)
    {
        try
        {
            Materia? materia = await _materiaRepository.Get(id);
            if (materia == null)
                return null;
            return new MateriaDto
            {
                Id = materia.Id,
                Descripcion = materia.Descripcion,
                HsSemanales = materia.HsSemanales,
                HsTotales = materia.HsTotales,
                IdPlan = materia.IdPlan,
                PlanDescripcion = materia.Plan.Descripcion,
            };
        }
        catch (Exception e)
        {
           throw new ApplicationException("error al obtener materia", e);
        }
    }

    public async Task<IEnumerable<MateriaDto>> GetAll()
    {
        try
        {
            var materias = await _materiaRepository.GetAll();
            return materias.Select(m => new MateriaDto
            {
                Id = m.Id,
                Descripcion = m.Descripcion,
                HsSemanales = m.HsSemanales,
                HsTotales = m.HsTotales,
                IdPlan = m.IdPlan,
                PlanDescripcion = m.Plan.Descripcion,
            });
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener materias", e);
        }
    }

    public async Task<bool> Update(MateriaDto dto)
    {
        try
        {
            Plan? plan = await _planRepository.Get(dto.IdPlan);
            Materia materia = new Materia(dto.Id,dto.Descripcion,dto.HsSemanales,dto.HsTotales,plan);
            return await _materiaRepository.Update(materia);
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al actualizar materia", e);
        }
    }
}