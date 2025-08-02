using Academia.Models;

namespace Academia.Data;

public class PlanData
{
	public static readonly List<Plan> planes = [];

	public void New(Plan plan)
	{
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

}
