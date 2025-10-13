namespace Academia.Models;

public class DocenteCursos: BusinessEntity
{
    public Curso Curso { get; private set; }
    public Persona Docente { get; private set; }
    public TiposCargos Cargo { get; private set; }
    public int IdCurso { get; private set; }
    public int IdDocente { get; private set; }

    public DocenteCursos(int id, Curso curso, Persona docente, string cargo) : base(id)
    {
        SetCurso(curso);
        SetDocente(docente);
        SetCargo(cargo);
    }

    public void SetCurso(Curso curso)
    {
        if (curso == null)
            throw new ArgumentNullException(nameof(curso));
        Curso = curso;
        IdCurso = curso.Id;
    }

    public void SetDocente(Persona docente)
    {
        if (docente == null)
            throw new ArgumentNullException(nameof(docente));
        Docente = docente;
        IdDocente = docente.Id;
    }

    public void SetCargo(string cargo)
    {
        if (!Enum.TryParse<TiposCargos>(cargo, ignoreCase: true, out var tipoCargo))
        {
            throw new ArgumentOutOfRangeException(nameof(cargo),$"Valor invalido: {cargo}");
        }
        Cargo = tipoCargo;
    }
    

}