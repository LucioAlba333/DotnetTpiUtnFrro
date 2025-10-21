using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;
using Microsoft.VisualBasic.CompilerServices;

namespace Academia.Services;

public class PlanService: IEntityService<PlanDto>
{
    private readonly PlanRepository _planRepository;
    private readonly EspecialidadRepository _especialidadRepository;

    public PlanService(PlanRepository planRepository, EspecialidadRepository especialidadRepository)
    {
        _planRepository = planRepository;
        _especialidadRepository = especialidadRepository;
    }
    public async Task New(PlanDto dto)
    {
        try
        {
            if (await _planRepository.PlanExists(dto.Descripcion))
                throw new ArgumentException("El plan ya existe");
            Especialidad? especialidad = await _especialidadRepository.Get(dto.EspecialidadId);
            if (especialidad != null)
            {
                Plan plan = new Plan(dto.Id, dto.Descripcion, especialidad);
                await _planRepository.Add(plan);
            }
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al crear el plan",e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
           return await _planRepository.Delete(id);
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al eliminar el plan",e);
        }
    }

    public async Task<PlanDto?> Get(int id)
    {
        try
        {
            Plan? plan = await _planRepository.Get(id);
            if(plan == null)
                return null;
            return new PlanDto
            {
                Id = plan.Id,
                Descripcion = plan.Descripcion,
                EspecialidadId = plan.EspecialidadId,
                DescripcionEspecialidad = plan.Especialidad.Descripcion,
            };
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener el plan",e);
        }
    }

    public async Task<IEnumerable<PlanDto>> GetAll()
    {
        try
        {
            var planes =  await _planRepository.GetAll();
            return planes.Select(p => new PlanDto
            {
                Id = p.Id,
                Descripcion = p.Descripcion,
                EspecialidadId = p.EspecialidadId,
                DescripcionEspecialidad = p.Especialidad.Descripcion,
            });
        }
        catch (Exception e)
        {
         
            throw new ApplicationException("error al obtener todos los planes",e);
        }
    }

    public async Task<bool> Update(PlanDto dto)
    {
        try
        {
            if (await _planRepository.PlanExists(dto.Descripcion, dto.Id))
                throw new ArgumentException("El plan ya existe");
            Especialidad? especialidad = await _especialidadRepository.Get(dto.EspecialidadId);
            if (especialidad == null)
                throw new ArgumentException("La especialidad no existe");
            Plan plan = new Plan(dto.Id, dto.Descripcion, especialidad);
            return await _planRepository.Update(plan);

        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al editar el plan",e);
        }
    }
}