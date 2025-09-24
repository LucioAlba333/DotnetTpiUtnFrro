namespace Academia.Models;

public class Especialidad : BusinessEntity
{
	public string Descripcion { get; private set; }
	public Especialidad(int id, string descripcion) : base(id)
	{
		SetDescripcion(descripcion);
	}

	protected Especialidad() { }
	public Especialidad(Especialidad especialidad) : base(especialidad)
	{
		Descripcion = especialidad.Descripcion;
	}

	public void SetDescripcion(string descripcion)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
			throw new ArgumentNullException(nameof(descripcion));
		Descripcion = descripcion;
	}
}
