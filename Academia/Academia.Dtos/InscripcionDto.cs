namespace Academia.Dtos;

public class InscripcionDto
{
    public int Id { get; set; }
    public int IdAlumno { get; set; }
    public int IdCurso { get; set; }
    public string NombreAlumno { get; set; } = string.Empty;
    public string Condicion { get; set; } = string.Empty;
    public int? Nota { get; set; }
}