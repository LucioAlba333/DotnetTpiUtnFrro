namespace Academia.Dtos;

public class PersonaDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty; 
    public string Apellido { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Legajo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int? IdPlan { get; set; }
    public string? DescripcionPlan { get; set; } = string.Empty;
    public string TipoPersona { get; set; } = string.Empty;
}