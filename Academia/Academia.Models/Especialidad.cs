using System.Text.Json.Serialization;

namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	[JsonConstructor]
	public Especialidad(int id, string descripcion) : base(id)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentException("la descripcion no puede ser nula o vacia", nameof(descripcion));
		Descripcion = descripcion;

	}
	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		this.Descripcion = especialidad.Descripcion;
	}

	public string Descripcion { get; set; }
}

