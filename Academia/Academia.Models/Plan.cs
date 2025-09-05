using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
    private string? _descripcion;
    private Especialidad _especialidad;

    public string? Descripcion
    {
	    get => _descripcion;
	    set => _descripcion = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Especialidad Especialidad
    {
	    get => _especialidad;
	    set => _especialidad = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Plan(int id, string? descripcion, Especialidad especialidad) : base(id)
    {
	    _descripcion = descripcion;
	    _especialidad = especialidad;
    }

    public Plan(Plan plan) : base(plan)
	{
		this.Descripcion = plan.Descripcion;
		this.Especialidad = plan.Especialidad;
	}

   
}
