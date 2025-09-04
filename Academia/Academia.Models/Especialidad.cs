using System.Text.Json.Serialization;

namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	private string _descripcion;
	private ICollection<Plan> _planes;

	public string Descripcion
	{
		get => _descripcion;
		set => _descripcion = value ?? throw new ArgumentNullException(nameof(value));
	}

	public ICollection<Plan> Planes
	{
		get => _planes;
		set => _planes = value ?? throw new ArgumentNullException(nameof(value));
	}

	public Especialidad(int id, string descripcion) : base(id)
	{
		_descripcion = descripcion;
	}

	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		Descripcion = especialidad.Descripcion;
		Planes = especialidad.Planes;
	}
}

