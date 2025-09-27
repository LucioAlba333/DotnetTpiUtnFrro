namespace Academia.Models;

public class Persona : BusinessEntity
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Direccion { get; private set; }
    public string Telefono { get; private set; }
    public string Email { get; private set; }
    public int? IdPlan { get; private set; }
    public int Legajo { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public TipoPersona TipoPersona { get; private set; }
    public Plan? Plan { get; private set; }

    protected Persona() { }
    public Persona(
        int id,
        string nombre,
        string apellido,
        string direccion,
        string telefono,
        string email,
        int legajo,
        DateTime fechaNacimiento,
        TipoPersona tipoPersona,
        Plan? plan
    ) : base(id)
    {
        SetNombre(nombre);
        SetApellido(apellido);
        SetDireccion(direccion);
        SetTelefono(telefono);
        SetEmail(email);
        SetLegajo(legajo);
        SetFechaNacimiento(fechaNacimiento);
        SetTipoPersona(tipoPersona);
        if (plan != null)
        {
            SetPlan(plan);
        }
    }

    public void SetNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentNullException(nameof(nombre));
        Nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentNullException(nameof(apellido));
        Apellido = apellido;
    }

    public void SetDireccion(string direccion)
    {
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentNullException(nameof(direccion));
        Direccion = direccion;
    }

    public void SetTelefono(string telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentNullException(nameof(telefono));
        Telefono = telefono;
    }

    public void SetEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email));
        Email = email;
    }

    public void SetLegajo(int legajo)
    {
        if (legajo <= 0)
            throw new ArgumentOutOfRangeException(nameof(legajo));
        Legajo = legajo;
    }

    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        if (fechaNacimiento < new DateTime(1900, 01, 01) || fechaNacimiento > DateTime.Now)
            throw new ArgumentOutOfRangeException(nameof(fechaNacimiento));
        FechaNacimiento = fechaNacimiento;
    }

    public void SetTipoPersona(TipoPersona tipoPersona)
    {
        if (!Enum.IsDefined(typeof(TipoPersona), tipoPersona))
            throw new ArgumentOutOfRangeException(nameof(tipoPersona));
        TipoPersona = tipoPersona;
    }

    public void SetPlan(Plan plan)
    {
        Plan = plan;
        IdPlan = plan.Id;
    }
}

