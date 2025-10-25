namespace Academia.Dtos;

public class DocenteCursosDto
{
    public int Id { get; set; }
    public int IdDocente { get; set; }
    public int IdCurso { get; set; }
    public string DocenteNombreCompleto { get; set; } = string.Empty;
    public string CursoDescripcion { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
}
