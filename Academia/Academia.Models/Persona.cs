namespace Academia.Models;

public class Persona : BusinessEntity
{
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
        int legajo, 
        DateTime fechaNacimiento, 
        TipoPersona tipoPersona, 
        Plan plan) : base(id)
    {
        this.SetNombre(nombre);
        this.SetApellido(apellido); 
        this.SetDireccion(direccion);
        this.SetTelefono(telefono);
        this.SetEmail(email);
        this.SetPlan(plan);
        this.SetTipoPersona(tipoPersona);
        this.SetFechaNacimiento(fechaNacimiento);
        this.SetLegajo(legajo);
    }

    public string Nombre => _nombre;

    public string Apellido => _apellido;

    public string Direccion => _direccion;

    public string Telefono => _telefono;

    public string Email => _email;

    public int IdPlan => _idPlan;

    public int Legajo => _legajo;

    public DateTime FechaNacimiento => _fechaNacimiento;

    public TipoPersona TipoPersona => _tipoPersona;

    public Plan Plan => _plan;

    public void SetNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentNullException(nameof(nombre));
        _nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentNullException(nameof(apellido));
        _apellido = apellido;
    }

    public void SetDireccion(string direccion)
    {
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentNullException(nameof(direccion));
        _direccion = direccion;
    }

    public void SetTelefono(string telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentNullException(nameof(telefono));
        _telefono = telefono;
    }

    public void SetEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email));
        _email = email;
    }

    public void SetLegajo(int legajo)
    {
        if (legajo <= 0)
            throw new ArgumentOutOfRangeException(nameof(legajo));
        _legajo = legajo;
    }
    
    
    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        if (fechaNacimiento < new DateTime(1900, 01, 01) || fechaNacimiento > DateTime.Now)
            throw new ArgumentOutOfRangeException(nameof(fechaNacimiento)); 
        _fechaNacimiento = fechaNacimiento;
    }

    public void SetPlan(Plan plan)
    {
        if (plan == null)
            throw new ArgumentNullException(nameof(plan));
        _plan = plan;
        _idPlan = plan.Id;
    }

    public void SetTipoPersona(TipoPersona tipoPersona)
    {
        if (!Enum.IsDefined(typeof(TipoPersona), tipoPersona))
            throw new ArgumentOutOfRangeException(nameof(tipoPersona));
        _tipoPersona = tipoPersona;
    }
    
}