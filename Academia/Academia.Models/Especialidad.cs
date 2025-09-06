namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	private string _descripcion;
	
	public string Descripcion => _descripcion;
	//public ICollection<Plan> Planes{get;}
	

	public Especialidad(int id, string? descripcion) : base(id)
	{
		_descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
	}

	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		_descripcion = especialidad.Descripcion;
		//Planes = especialidad.Planes;
	}

	public void CambiarDescripcion(string descripcion)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentNullException(nameof(descripcion));
		_descripcion = descripcion;
	}
}

