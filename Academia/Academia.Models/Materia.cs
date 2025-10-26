namespace Academia.Models;

public class Materia : BusinessEntity
{
    public string Descripcion { get; private set; }
    public int HsSemanales {get; private set;}
    public int HsTotales { get; private set; }
    public Plan Plan {get ; private set;}
    public int IdPlan {get; private set;}

    public Materia(string descripcion, int hsSemanales, int hsTotales, Plan plan)
    {
        Descripcion = descripcion;
        HsSemanales = hsSemanales;
        HsTotales = hsTotales;
        Plan = plan;
    }

    public Materia(int id, string descripcion, int hsSemanales, int hsTotales, Plan plan) : base(id)
    {
        SetDescripcion(descripcion);
        SetHsSemanales(hsSemanales);
        SetHsTotales(hsTotales);
        SetPlan(plan);
    }
    

    public void SetDescripcion(string descripcion)
    {
        if (string.IsNullOrWhiteSpace(descripcion))
        {
            throw new ArgumentNullException(nameof(descripcion));
        }
        this.Descripcion = descripcion;
    }

    public void SetHsSemanales(int hsSemanales)
    {
        if (hsSemanales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(hsSemanales));
        }
        this.HsSemanales = hsSemanales;
    }

    public void SetHsTotales(int hsTotales)
    {
        if (hsTotales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(hsTotales));
        }
        this.HsTotales = hsTotales;
    }

    public void SetPlan(Plan plan)
    {
        if (plan == null)
        {
            throw new ArgumentNullException(nameof(plan));
        }
        this.Plan = plan;
        this.IdPlan = plan.Id;
    }
    protected Materia() { }
    
    
    
}