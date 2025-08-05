using Academia.Data.Interfaces;
using Academia.Models;

namespace Academia.Data;

public class EspecialidadData : ICrud<Especialidad>
{
	public static readonly List<Especialidad> especialidades = [];
	public static int idActual = 1;

	public void New(Especialidad especialidad)
	{
		especialidad.Id = idActual++;
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
	public bool Update(Especialidad entity)
	{
		Especialidad? e =
			especialidades.Find(x => x.Id == entity.Id);
		if (e != null)
		{
			e.State = entity.State;
			e.Descripcion = entity.Descripcion;
			return true;
		}
		else
			return false;

	}





}
