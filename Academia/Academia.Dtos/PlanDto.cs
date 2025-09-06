using System.ComponentModel.DataAnnotations;

namespace Academia.Dtos;

public class PlanDto
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Descripcion { get; set; } = string.Empty;
    public int EspecialidadId { get; set; }
    [Required]
    [StringLength(50)]
    public string DescripcionEspecialidad { get; set; } = string.Empty;
}