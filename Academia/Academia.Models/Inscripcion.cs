namespace Academia.Models;

public class Inscripcion: BusinessEntity
{
    public Persona Alumno { get; private set; }
    public Curso Curso { get; private set; }
    public string Condicion {get; private set;}
    public int Nota {get; private set;}
    public int IdAlumno {get; private set;}
    public int IdCurso {get; private set;}

    protected Inscripcion(){}
    public Inscripcion(int id, Persona alumno, Curso curso, string condicion, int nota) : base(id)
    {
        SetAlumno(alumno);
        SetCurso(curso);
        SetCondicion(condicion);
        SetNota(nota);
    }

    public void SetAlumno(Persona alumno)
    {
        if (alumno == null)
            throw new ArgumentNullException(nameof(alumno));
        Alumno = alumno;
        IdAlumno = alumno.Id;
    }

    public void SetCurso(Curso curso)
    {
        if (curso == null)
            throw new ArgumentNullException(nameof(curso));
        Curso = curso;
        IdCurso = curso.Id;
    }

    public void SetCondicion(string condicion)
    {
        if (string.IsNullOrWhiteSpace(condicion))
            throw new ArgumentNullException(nameof(condicion));
        Condicion = condicion;
    }

    public void SetNota(int nota)
    {
        if(nota<0 || nota > 100)
            throw new ArgumentOutOfRangeException(nameof(nota));
        Nota = nota;
    }
    
    
}