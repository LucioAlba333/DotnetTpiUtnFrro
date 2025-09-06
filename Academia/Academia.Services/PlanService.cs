using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class PlanService: IEntityService<PlanDto>
{
    public void New(PlanDto dto)
    {
        dto.Id = PlanData.GenerarId();
        Especialidad especialidad = new Especialidad(dto.EspecialidadId,dto.DescripcionEspecialidad);
        Plan plan = new Plan(dto.Id, dto.Descripcion, especialidad);
        PlanData.Planes.Add(plan);
    }

    public bool Delete(int id)
    {
        Plan? plan
            = PlanData.Planes.Find(x => x.Id == id);
        if (plan != null)
        {
            PlanData.Planes.Remove(plan);
            return true;
        }
        return false;
    }

    public PlanDto? Get(int id)
    {
        Plan? plan =
            PlanData.Planes.Find(x => x.Id == id);

        if (plan != null)
            return new PlanDto
            {
                Id = plan.Id, 
                Descripcion = plan.Descripcion,
                EspecialidadId = plan.Especialidad.Id,
                DescripcionEspecialidad = plan.Especialidad.Descripcion,
            };
        return null;
    }

    public IEnumerable<PlanDto> GetAll()
    {
        var planes= PlanData.Planes.Select(p => new Plan(p)).ToList();
        return planes.Select(plan => new PlanDto
        {
            Id = plan.Id,
            Descripcion = plan.Descripcion,
            EspecialidadId =  plan.Especialidad.Id,
            DescripcionEspecialidad = plan.Especialidad.Descripcion,
        });
    }

    public bool Update(PlanDto dto)
    {
        Plan? p =
            PlanData.Planes.Find(x => x.Id == dto.Id);
        if (p != null)
        {
            Especialidad especialidad = new Especialidad(dto.EspecialidadId, dto.DescripcionEspecialidad);
            p.CambiarDescripcion(dto.Descripcion);
            p.CambiarEspecialidad(especialidad);
            return true;
        }
        return false;
    }    
}