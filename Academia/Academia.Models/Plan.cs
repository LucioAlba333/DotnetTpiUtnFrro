using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
	public string Descripcion { get; set; }
	public int IdEspecialidad { get; set; }

	[JsonConstructor]
	public Plan(int id, int idEspecialidad, string descripcion) : base(id)
	{

		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentException("la descripcion no puede ser nula o vacia", nameof(descripcion));
		Descripcion = descripcion;
		IdEspecialidad = idEspecialidad;
	}
	public Plan(Plan plan) : base(plan)
	{
		this.Descripcion = plan.Descripcion;
		this.IdEspecialidad = plan.IdEspecialidad;
	}
}
