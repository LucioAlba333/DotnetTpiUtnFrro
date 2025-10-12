namespace Academia.Models;

public class Comision : BusinessEntity
{
    public string Descripcion { get; private set; }
    public int AnioEspecialidad { get; private set; }
    public int IdPlan {get; private set;}
    public Plan Plan {get; private set;}

    protected Comision()
    {
    }

    public Comision(int id, string descripcion, int anioEspecialidad, Plan plan) : base(id)
    {
        SetDescripcion(descripcion);
        SetAnioEspecialidad(anioEspecialidad);
        SetPlan(plan);
    }

    public void SetDescripcion(string descripcion)
    {
        if (string.IsNullOrWhiteSpace(descripcion))
            throw new ArgumentNullException(nameof(descripcion));
        Descripcion = descripcion;
    }

    public void SetAnioEspecialidad(int anioEspecialidad)
    {
        if (anioEspecialidad < 0 || anioEspecialidad > 5)
            throw new ArgumentOutOfRangeException(nameof(anioEspecialidad));
        AnioEspecialidad = anioEspecialidad;
    }

    public void SetPlan(Plan plan)
    {
        if (plan == null)
            throw new ArgumentNullException(nameof(plan));
        Plan = plan;
        IdPlan = plan.Id;
    }
}