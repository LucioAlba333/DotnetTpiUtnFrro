using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
	public string Descripcion { get; private set; }

	public int EspecialidadId { get; private set; }

	public Especialidad Especialidad { get; private set; }

	protected Plan() {}
	public Plan(int id, string descripcion, Especialidad especialidad) : base(id)
	{
		SetDescripcion(descripcion);
		SetEspecialidad(especialidad);
	}

	public Plan(Plan plan) : base(plan)
	{
		Descripcion = plan.Descripcion;
		Especialidad = plan.Especialidad;
		EspecialidadId = plan.EspecialidadId;
	}

	public void SetDescripcion(string descripcion)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentNullException(nameof(descripcion));
		Descripcion = descripcion;
	}

	public void SetEspecialidad(Especialidad especialidad)
	{
		Especialidad = especialidad ?? throw new ArgumentNullException(nameof(especialidad));
		EspecialidadId = especialidad.Id;
	}
}

