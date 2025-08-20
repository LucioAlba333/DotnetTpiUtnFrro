using Academia.Data;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class EspecialidadService: ICrud<Especialidad>
{
    public void New(Especialidad plan)
    {
        plan.Id = EspecialidadData.GenerarId();
        EspecialidadData.Especialidades.Add(plan);
    }

    public bool Delete(int id)
    {
        Especialidad? especialidad =
            EspecialidadData.Especialidades.Find(x => x.Id == id);
        if (especialidad != null)
        {
            EspecialidadData.Especialidades.Remove(especialidad);
            return true;
        }
        else
            return false;
    }

    public Especialidad? Get(int id)
    {
        Especialidad? e = EspecialidadData.Especialidades.Find(x => x.Id == id);

        if (e != null)
        {
            return new Especialidad(e);
        }

        return null;
    }

    public IEnumerable<Especialidad> GetAll()
    {
       return EspecialidadData.Especialidades.Select(e => new Especialidad(e)).ToList();
    }

    public bool Update(Especialidad plan)
    {
        Especialidad? e =
            EspecialidadData.Especialidades.Find(x => x.Id == plan.Id);
        if (e != null)
        {
            e.State = plan.State;
            e.Descripcion = plan.Descripcion;
            return true;
        }
        return false;
    }
}