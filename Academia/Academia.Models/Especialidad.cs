namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	private string _descripcion;
	
	public string Descripcion => _descripcion;
	//public ICollection<Plan> Planes{get;}
	

	public Especialidad(int id, string descripcion) : base(id)
	{
		SetDescripcion(descripcion);
	}

	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		_descripcion = especialidad.Descripcion;
		//Planes = especialidad.Planes;
	}

	public void SetDescripcion(string descripcion)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentNullException(nameof(descripcion));
		_descripcion = descripcion;
	}
}

