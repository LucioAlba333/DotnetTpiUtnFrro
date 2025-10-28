using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Profesores.Modals;

public partial class CrearModal : Form
{
    public CrearModal()
    {
        InitializeComponent();
    }
    private async void buttonEnviar_Click(object sender, EventArgs e)
    {
        try
        {

            PersonaDto persona = new PersonaDto
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                Direccion = textBoxDireccion.Text,
                Telefono = textBoxTelefono.Text,
                Email = textBoxEmail.Text,
                FechaNacimiento = dateTimePickerNacimiento.Value.Date,
                TipoPersona = "Profesor",
            };
            await PersonaApiClient.AddAsync(persona);
            this.DialogResult = DialogResult.OK;
            this.Close();
            

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al enviar persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttoncancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private async void CrearModal_Load(object sender, EventArgs e)
    {
    }
}