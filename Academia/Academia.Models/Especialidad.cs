using System.Text.Json.Serialization;

namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	private string _decripcion;
	public Especialidad() { }
	[JsonConstructor]
	public Especialidad(int id, string descripcion) : base(id)
	{
		Descripcion = descripcion;
	}
	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		this.Descripcion = especialidad.Descripcion;
	}

	public string Descripcion
	{
		get { return _decripcion; }
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentException("la descripcion no puede ser nula o vacia", nameof(value));
			_decripcion = value;

		}
	}
}

