using Academia.Models;

namespace Academia.Data;

public class EspecialidadData
{
	public static readonly List<Especialidad> Especialidades = [];
	private static int _idActual = 1;

	public static int GenerarId()
	{		
		return _idActual++;
	}
	
}
