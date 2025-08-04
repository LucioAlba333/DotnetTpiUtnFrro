using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
    private string _decripcion;

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
    public int IdEspecialidad { get; set; }
	public Especialidad Especialidad { get; set; }
	public Plan() { }
	[JsonConstructor]
	public Plan(int id, Especialidad especialidad, string descripcion) : base(id)
	{

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
