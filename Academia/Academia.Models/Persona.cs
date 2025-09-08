namespace Academia.Models;

public class Persona : BusinessEntity
{
    public static DateTime FechaMinima = new DateTime(1900, 1, 1);
    public static DateTime FechaMaxima = DateTime.Now;
    private string _nombre;
    private string _apellido;
    private string _direccion;
    private string _telefono;
    private string _email;
    private int _idPlan;
    private int _legajo;
    private DateTime _fechaNacimiento;
    private TipoPersona _tipoPersona;
    private Plan _plan;

    public Persona(int id, 
        string nombre, 
        string apellido, 
        string direccion, 
        string telefono, 
        string email, 
        int idPlan, 
        int legajo, 
        DateTime fechaNacimiento, 
        TipoPersona tipoPersona, 
        Plan plan) : base(id)
    {
        _nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        _apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
        _direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
        _telefono = telefono  ?? throw new ArgumentNullException(nameof(telefono));
        _email = email  ?? throw new ArgumentNullException(nameof(email));
        _idPlan = idPlan ;
        _legajo = legajo > 0 ? legajo : throw new ArgumentOutOfRangeException(nameof(legajo));
        _fechaNacimiento = fechaNacimiento;
        _tipoPersona = tipoPersona;
        _plan = plan;
    }

    public string Nombre => _nombre;

    public string Apellido => _apellido;

    public string Direccion => _direccion;

    public string Telefono => _telefono;

    public string Email => _email;

    public int IdPlan1 => _idPlan;

    public int Legajo => _legajo;

    public DateTime FechaNacimiento => _fechaNacimiento;

    public TipoPersona TipoPersona => _tipoPersona;

    public Plan Plan => _plan;

    public void CambiarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentNullException(nameof(nombre));
        _nombre = nombre;
    }

    public void CambiarApellido(string apellido)
    {
        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentNullException(nameof(apellido));
        _apellido = apellido;
    }

    public void CambiarDireccion(string direccion)
    {
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentNullException(nameof(direccion));
        _direccion = direccion;
    }

    public void CambiarTelefono(string telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentNullException(nameof(telefono));
        _telefono = telefono;
    }

    public void CambiarEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email));
        _email = email;
    }

    public void CambiarLegajo(int legajo)
    {
        if (legajo <= 0)
            throw new ArgumentOutOfRangeException(nameof(legajo));
        _legajo = legajo;
    }
    
    
    public void CambiarFechaNacimiento(DateTime fechaNacimiento)
    {
        if (DateTime.Compare(DateTime.Now, fechaNacimiento) > 0)
            _fechaNacimiento = fechaNacimiento;
    }
    
}