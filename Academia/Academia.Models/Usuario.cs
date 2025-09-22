namespace Academia.Models;

public class Usuario : BusinessEntity
{
    private Persona _persona;
    private string _nombreUsuario;
    private string _clave;

    public string NombreUsuario => _nombreUsuario;

    public string Clave => _clave;

    public Persona Persona => _persona;

    public Usuario(int id, Persona persona, string nombreUsuario, string clave) : base(id)
    {
        SetPersona(persona);
        SetNombreUsuario(nombreUsuario);
        SetClave(clave);
    }

    public void SetNombreUsuario(string nombreUsuario)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario))
            throw new ArgumentNullException(nameof(nombreUsuario));
        _nombreUsuario = nombreUsuario;
    }

    public void SetClave(string clave)
    {
        if (string.IsNullOrWhiteSpace(clave))
            throw new ArgumentNullException(nameof(clave));
        _clave = clave;
    }

    public void SetPersona(Persona persona)
    {
        if (persona == null)
            throw new ArgumentNullException(nameof(persona));
        _persona = persona;
    }
}