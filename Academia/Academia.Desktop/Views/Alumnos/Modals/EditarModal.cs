using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Alumnos.Modals;

public partial class EditarModal : Form
{
    private bool _estaCargando = false;
    public EditarModal()
    {
        InitializeComponent();
    }
    private async Task CargaDatos()
    {
        try
        {
            _estaCargando = true;
            List<PersonaDto> personas = (List<PersonaDto>)await PersonaApiClient.GetAlumnosAsync();
            this.comboBox2.DataSource = personas;
            this.comboBox2.DisplayMember = "Legajo";
            this.comboBox2.SelectedIndex = -1;
            this.comboBox2.ValueMember = "Id";
            List<PlanDto> planes = (List<PlanDto>)await PlanApiClient.GetAllAsync();
            this.comboBox1.DataSource = planes;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.ValueMember = "Id";
            _estaCargando = false;

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
            if (this.comboBox1.SelectedItem is PlanDto plan &&  this.comboBox2.SelectedItem is PersonaDto alumno)
            {
                alumno.Nombre = textBoxNombre.Text;
                alumno.Apellido = textBoxApellido.Text;
                alumno.Direccion = textBoxDireccion.Text;
                alumno.Telefono = textBoxTelefono.Text;
                alumno.Email = textBoxEmail.Text;
                alumno.FechaNacimiento = dateTimePickerNacimiento.Value.Date;
                alumno.IdPlan = plan.Id;
                alumno.DescripcionPlan = plan.Descripcion;
                await PersonaApiClient.UpdateAsync(alumno);

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

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this._estaCargando) return;
        if(this.comboBox2.SelectedItem is PersonaDto)
        {
            PersonaDto persona = (PersonaDto)comboBox2.SelectedItem;
            this.textBoxNombre.Text = persona.Nombre;
            this.textBoxApellido.Text = persona.Apellido;
            this.textBoxDireccion.Text = persona.Direccion;
            this.textBoxEmail.Text = persona.Email;
            this.textBoxTelefono.Text = persona.Telefono;
            this.dateTimePickerNacimiento.Value = persona.FechaNacimiento;
            this.comboBox1.SelectedValue = persona.IdPlan;
        }
    }
}