using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Profesores.Modals;

public partial class GenerarUsuarioModal : Form
{
    public GenerarUsuarioModal()
    {
        InitializeComponent();
    }
    private async Task CargaDatos()
    {
        try
        {
            List<PersonaDto> profesor = (List<PersonaDto>)await PersonaApiClient.GetProfesoresAsync();
            this.comboBox1.DataSource = profesor;
            this.comboBox1.DisplayMember = "Legajo";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.comboBox1.SelectedItem is PersonaDto)
            {
                PersonaDto profesor = (PersonaDto)this.comboBox1.SelectedItem;
                UsuarioCreateDto usuarioCreateDto = new UsuarioCreateDto()
                {
                    NombreUsuario = profesor.Legajo.ToString(),
                    Clave = profesor.Apellido,
                    PersonaId = profesor.Id
                };
                await UsuarioApiClient.AddAsync(usuarioCreateDto);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Usuario guardado correctamente, usando legajo como nombre y apellido como clave, el usuario debe cambiar la contraseña",
                    "Usuario guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void button2_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private async void GenerarUsuarioModal_Load(object sender, EventArgs e)
    {
        await CargaDatos();
    }
}