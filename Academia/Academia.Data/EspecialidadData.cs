using Academia.Models;

namespace Academia.Data;

public class EspecialidadData
{
	public static readonly List<Especialidad> especialidades = [];

	public static void New(Especialidad especialidad)
	{
		especialidades.Add(especialidad);
	}

	public static bool Delete(int id)
	{
		Especialidad? especialidad =
			especialidades.Find(x => x.Id == id);
		if (especialidad != null)
		{
			especialidades.Remove(especialidad);
			return true;
		}
		else
			return false;
	}
	public static Especialidad? Get(int id)
	{
		Especialidad? e = especialidades.Find(x => x.Id == id);

		if (e != null)
		{
			return new Especialidad(e);
		}
		else
			return null;
	}
	public static IEnumerable<Especialidad> GetAll()
	{
		return especialidades.Select(e => new Especialidad(e)).ToList();
	}
	public static bool Update(Especialidad especialidad)
	{
		Especialidad? e =
			especialidades.Find(x => x.Id == especialidad.Id);
		if (e != null)
		{
			e.State = especialidad.State;
			e.Descripcion = especialidad.Descripcion;
			return true;
		}
		else
			return false;

	}





}
