namespace Academia.Dtos;

public class PlanDto
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public int EspecialidadId { get; set; }
    public string? DescripcionEspecialidad { get; set; }
}