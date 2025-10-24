namespace Academia.Dtos;

public class CursoDto
{
    public int Id { get; set; }
    public int IdMateria { get; set; }
    public string MateriaDescripcion { get; set; } = string.Empty;

    public int IdComision { get; set; }
    public string ComisionDescripcion { get; set; } = string.Empty;

    public int AnioCalendario { get; set; }
    public int Cupo { get; set; }
}