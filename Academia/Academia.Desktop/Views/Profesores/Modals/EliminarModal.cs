using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Profesores.Modals;

public partial class EliminarModal : Form
{
    public EliminarModal()
    {
        InitializeComponent();
    }
    private async void EliminarModal_Load(object sender, EventArgs e)
    {
        await CargaDatos();
    }
    private async Task CargaDatos()
    {
        try
        {
            List<PersonaDto> profesores = (List<PersonaDto>)await PersonaApiClient.GetProfesoresAsync();
            this.comboBox1.DataSource = profesores;
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
                await PersonaApiClient.DeleteAsync(profesor.Id);
                this.DialogResult = DialogResult.OK;
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
}