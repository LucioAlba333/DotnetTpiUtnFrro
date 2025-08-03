using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
	public string Descripcion { get; set; }
	public int IdEspecialidad { get; set; }
	public Especialidad Especialidad { get; set; }

	[JsonConstructor]
	public Plan(int id, Especialidad especialidad, string descripcion) : base(id)
	{

		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentException("la descripcion no puede ser nula o vacia", nameof(descripcion));
		Descripcion = descripcion;
		Especialidad = especialidad;
		IdEspecialidad = especialidad.Id;
	}
	public Plan(Plan plan) : base(plan)
	{
		this.Descripcion = plan.Descripcion;
		this.IdEspecialidad = plan.IdEspecialidad;
		this.Especialidad = plan.Especialidad;
	}
}
