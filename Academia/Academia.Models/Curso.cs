namespace Academia.Models;

public class Curso : BusinessEntity
{
    public Materia Materia { get; private set; }
    public Comision Comision { get; private set; }
    public int AnioCalendario { get; private set; }
    public int Cupo {get; private set;}
    public int IdMateria {get; private set;}
    public int IdComision {get; private set;}

    public Curso(int id,
        Materia materia,
        Comision comision,
        int anioCalendario,
        int cupo) : base(id)
    {
        SetMateria(materia);
        SetComision(comision);
        SetAnioCalendario(anioCalendario);
        SetCupo(cupo);
    }
    protected Curso(){}
    public void SetMateria(Materia materia)
    {
        if (materia == null)
            throw new ArgumentNullException(nameof(materia));
        Materia = materia;
        IdMateria = Materia.Id;
    }

    public void SetComision(Comision comision)
    {
        if (comision == null)
            throw new ArgumentNullException(nameof(comision));
        Comision = comision;
        IdComision = comision.Id;
    }

    public void SetCupo(int cupo)
    {
        if (cupo < 0)
            throw new ArgumentOutOfRangeException(nameof(cupo));
        Cupo = cupo;
    }

    public void SetAnioCalendario(int anioCalendario)
    {
        if (anioCalendario < 0)
            throw new ArgumentOutOfRangeException(nameof(anioCalendario));
        AnioCalendario = anioCalendario;
    }
    
}