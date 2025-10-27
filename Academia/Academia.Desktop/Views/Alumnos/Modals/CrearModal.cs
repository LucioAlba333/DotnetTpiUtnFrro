using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Alumnos.Modals;

public partial class CrearModal : Form
{
    public CrearModal()
    {
        InitializeComponent();
    }
    private async Task CargaDatos()
    {
        try
        {
            List<PlanDto> planes = (List<PlanDto>)await PlanApiClient.GetAllAsync();
            this.comboBox1.DataSource = planes;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.ValueMember = "Id";

        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private async void buttonEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.comboBox1.SelectedItem is PlanDto plan)
            {
                PersonaDto persona = new PersonaDto
                {
                    Nombre = textBoxNombre.Text,
                    Apellido = textBoxApellido.Text,
                    Direccion = textBoxDireccion.Text,
                    Telefono = textBoxTelefono.Text,
                    Email = textBoxEmail.Text,
                    FechaNacimiento = dateTimePickerNacimiento.Value.Date,
                    TipoPersona = "Alumno",
                    IdPlan = plan.Id,
                    DescripcionPlan = plan.Descripcion
                };

                await PersonaApiClient.AddAsync(persona);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                throw new Exception("No se seleccionó un plan válido.");
            }
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
        await CargaDatos();
    }
}