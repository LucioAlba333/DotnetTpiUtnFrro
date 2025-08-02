using Academia.Data.Interfaces;
using Academia.Models;

namespace Academia.Data;

public class EspecialidadData : ICrud<Especialidad>
{
	public static readonly List<Especialidad> especialidades = [];

	public void New(Especialidad especialidad)
	{
		especialidades.Add(especialidad);
	}

	public bool Delete(int id)
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
	public Especialidad? Get(int id)
	{
		Especialidad? e = especialidades.Find(x => x.Id == id);

		if (e != null)
		{
			return new Especialidad(e);
		}
		else
			return null;
	}
	public IEnumerable<Especialidad> GetAll()
	{
		return especialidades.Select(e => new Especialidad(e)).ToList();
	}
	public bool Update(Especialidad especialidad)
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
