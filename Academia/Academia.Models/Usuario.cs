namespace Academia.Models;

public class Usuario : BusinessEntity
{
    public Persona Persona { get; private set; }
    public int IdPersona { get; private set; }
    public string NombreUsuario { get; private set; }
  
    public string Clave { get; private set; }
    public ICollection<ModuloUsuario> Permisos { get; set; } = new List<ModuloUsuario>();
    protected Usuario() { }
    public Usuario(int id, Persona persona, string nombreUsuario, string clave) : base(id)
    {
        SetPersona(persona);
        SetNombreUsuario(nombreUsuario);
        SetClave(clave);
    }

    public void SetPersona(Persona persona)
    {
        if (persona == null)
            throw new ArgumentNullException(nameof(persona));
        Persona = persona;
        IdPersona = persona.Id;
    }

    public void SetNombreUsuario(string nombreUsuario)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario))
            throw new ArgumentNullException(nameof(nombreUsuario));
        NombreUsuario = nombreUsuario;
    }

    public void SetClave(string clave)
    {
        if (string.IsNullOrWhiteSpace(clave))
            throw new ArgumentNullException(nameof(clave));
        Clave = clave;
    }
}