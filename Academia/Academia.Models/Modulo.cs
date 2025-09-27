namespace Academia.Models;

public class Modulo : BusinessEntity
{
    public string Descripcion { get; private set; }

    protected Modulo() { }
    public Modulo(int id, string descripcion) : base(id)
    {
        SetDescripcion(descripcion);
    }

    public void SetDescripcion(string descripcion)
    {
        if (string.IsNullOrWhiteSpace(descripcion))
        {
            throw new ArgumentNullException(nameof(descripcion));
        }
        Descripcion = descripcion;
    }
}