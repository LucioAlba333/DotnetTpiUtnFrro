namespace Academia.Models;

public class ModuloUsuario : BusinessEntity
{
    public Usuario Usuario { get; private set; }
    public Modulo Modulo { get; private set; }
    public int IdUsuario { get; private set; }
    public int IdModulo {get; private set;}
    public bool Alta {get; private set;}
    public bool Baja {get; private set;}
    public bool Modificacion {get; private set;}
    public bool Consulta {get; private set;}

    public ModuloUsuario(
        int id, 
        Usuario usuario, 
        Modulo modulo, 
        bool alta, 
        bool baja, 
        bool modificacion, 
        bool consulta) : base(id)
    {
        SetUsuario(usuario);
        SetModulo(modulo);
        SetAlta(alta);
        SetBaja(baja);
        SetModificacion(modificacion);
        SetConsulta(consulta);
    }

    public void SetUsuario(Usuario usuario)
    {
        if (usuario == null)
            throw new ArgumentNullException(nameof(usuario));
        Usuario = usuario;
        IdUsuario = usuario.Id;
    }

    public void SetModulo(Modulo modulo)
    {
        if (modulo == null)
            throw new ArgumentNullException(nameof(modulo));
        Modulo = modulo;
        IdModulo = Modulo.Id;
    }

    public void SetBaja(bool baja)
    {
        Baja = baja;
    }

    public void SetConsulta(bool consulta)
    {
        Consulta = consulta;
    }
    public void SetAlta(bool alta)
    {
        Alta = alta;
    }

    public void SetModificacion(bool modificacion)
    {
        Modificacion = modificacion;
    }
    
    
    
    
}