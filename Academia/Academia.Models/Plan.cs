using System.Text.Json.Serialization;

namespace Academia.Models;

public class Plan : BusinessEntity
{
    private string _decripcion;
    private string _especialidadDescripcion;
    public string Descripcion
    {
        get => _decripcion;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("la descripcion no puede ser nula o vacia", nameof(value));
            _decripcion = value;

        }
    }

    public string EspecialidadDescripcion
    {
	    get => _especialidadDescripcion;
	    set
	    {
		    if (string.IsNullOrWhiteSpace(value))
			    throw new ArgumentException("la descripcion no puede ser nulo o vacia", nameof(value));
		    _especialidadDescripcion = value;
	    }
    }
    public int IdEspecialidad { get; set; }
    
	public Plan() { }
	[JsonConstructor]
	public Plan(int id,int idEspcialidad ,string descripcion) : base(id)
	{

		Descripcion = descripcion;
		IdEspecialidad = idEspcialidad;
	}
	public Plan(Plan plan) : base(plan)
	{
		this.Descripcion = plan.Descripcion;
		this.IdEspecialidad = plan.IdEspecialidad;
		this.EspecialidadDescripcion = plan.EspecialidadDescripcion;
	}
   
}
