using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
    private string _descripcion;
    private Especialidad _especialidad;

    public string Descripcion => _descripcion;

    public Especialidad Especialidad => _especialidad;
    public Plan(int id, string descripcion, Especialidad especialidad) : base(id)
    {
	    _descripcion = descripcion;
	    _especialidad = especialidad;
    }

    public Plan(Plan plan) : base(plan)
	{
		_descripcion = plan.Descripcion;
		_especialidad = plan.Especialidad;
	}
	public void SetDescripcion(string descripcion)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentNullException(nameof(descripcion));
		_descripcion = descripcion;
	}

	public void SetEspecialidad(Especialidad especialidad)
	{
		_especialidad = especialidad ?? throw new ArgumentNullException(nameof(especialidad));
	}

   
}
