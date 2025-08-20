using Academia.Data;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class PlanService: ICrud<Plan>
{
    public void New(Plan plan)
    {
        plan.Id = PlanData.GenerarId();
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

    public Plan? Get(int id)
    {
        Plan? plan =
            PlanData.Planes.Find(x => x.Id == id);

        if (plan != null)
            return new Plan(plan);
        return null;
    }

    public IEnumerable<Plan> GetAll()
    {
        return PlanData.Planes.Select(p => new Plan(p)).ToList();
    }

    public bool Update(Plan plan)
    {
        Plan? p =
            PlanData.Planes.Find(x => x.Id == plan.Id);
        if (p != null)
        {
            p.Descripcion = plan.Descripcion;
            p.State = plan.State;
            p.IdEspecialidad = plan.IdEspecialidad;
            p.EspecialidadDescripcion = plan.EspecialidadDescripcion;
            return true;
        }
        return false;
    }    
}