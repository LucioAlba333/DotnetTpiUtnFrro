using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class ComisionService: IEntityService<ComisionDto>
{
    private readonly ComisionRepository _comisionRepository;
    private readonly PlanRepository _planRepository;


    public ComisionService(ComisionRepository comisionRepository, PlanRepository planRepository)
    {
        _comisionRepository = comisionRepository;
        _planRepository = planRepository;
    }

    public async Task New(ComisionDto comisionDto)
    {
        try
        {
            Plan? plan = await _planRepository.Get(comisionDto.IdPlan);
            if (plan != null) 
            {
                Comision comision = new Comision(comisionDto.Id,
                    comisionDto.Descripcion,
                    comisionDto.AnioEspecialidad,
                    plan);
                await _comisionRepository.Add(comision);
            }
            
        }
        catch (Exception e)
        {
            throw new Exception("error al crear la comision", e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _comisionRepository.Delete(id);

        }
        catch (Exception e)
        {
            throw new Exception("error al eliminar la comision", e);
        }
    }

    public async Task<ComisionDto?> Get(int id)
    {
        try
        {
            var comision = await _comisionRepository.Get(id);
            if (comision == null) 
                return null;
            return new ComisionDto
            {
                Id = comision.Id,
                Descripcion = comision.Descripcion,
                AnioEspecialidad = comision.AnioEspecialidad,
                PlanDescripcion = comision.Plan.Descripcion,
                IdPlan = comision.IdPlan,
            };

        }
        catch (Exception e)
        {
            throw new Exception("error al obtener la comision", e);
        }
    }

    public async Task<IEnumerable<ComisionDto>> GetAll()
    {
        try
        {
            var comisiones = await _comisionRepository.GetAll();
            return comisiones.Select(e=>new ComisionDto
            {
                Id = e.Id,
                Descripcion = e.Descripcion,
                AnioEspecialidad = e.AnioEspecialidad,
                PlanDescripcion = e.Plan.Descripcion,
                IdPlan = e.IdPlan,
            });

        }
        catch (Exception e)
        {
            throw new Exception("error al obtener las comisiones", e);
        }
        
    }

    public async Task<bool> Update(ComisionDto dto)
    {
        try
        {
            var plan = await _planRepository.Get(dto.IdPlan);
            if (plan == null)
                throw new ArgumentException("el plan no existe");
            Comision comision = new Comision(dto.Id,
                dto.Descripcion,
                dto.AnioEspecialidad,
                plan);
            return await _comisionRepository.Update(comision);

        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new Exception("error al actualizar la comision", e);
        }
    }
}

