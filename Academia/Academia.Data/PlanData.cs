using Academia.Data.Interfaces;
using Academia.Models;

namespace Academia.Data;

public class PlanData : ICrud<Plan>
{
	public static readonly List<Plan> planes = [];
    public static int idActual = 1;

    public void New(Plan plan)
	{
		plan.Id = idActual++;
		planes.Add(plan);
	}

	public bool Delete(int id)
	{
		Plan? plan
			= planes.Find(x => x.Id == id);
		if (plan != null)
		{
			planes.Remove(plan);
			return true;
		}
		else
			return false;

	}

	public Plan? Get(int id)
	{
		Plan? plan =
			planes.Find(x => x.Id == id);

		if (plan != null)
			return new Plan(plan);
		else
			return null;
	}

	public IEnumerable<Plan> GetAll()
	{
		return planes.Select(e => new Plan(e)).ToList();
	}

	public bool Update(Plan entity)
	{
		Plan? plan =
			planes.Find(x => x.Id == entity.Id);
		if (plan != null)
		{
			plan.Descripcion = entity.Descripcion;
			plan.State = entity.State;
			plan.IdEspecialidad = entity.IdEspecialidad;
			plan.Especialidad = entity.Especialidad;
			return true;
		}
		else
			return false;
	}
}
