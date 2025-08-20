using Academia.Models;

namespace Academia.Data;

public class PlanData
{
	public static readonly List<Plan> Planes = [];
    private static int _idActual = 1;

    public static int GenerarId()
    {
	    return _idActual++;
    }
	
}
