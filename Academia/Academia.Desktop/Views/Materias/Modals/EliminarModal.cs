using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Materias.Modals;

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
            List<MateriaDto> materias = (List<MateriaDto>)await MateriaApiClient.GetAllAsync();
            this.comboBox1.DataSource = materias;
            this.comboBox1.DisplayMember = "Descripcion";
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
            if (this.comboBox1.SelectedItem is MateriaDto)
            {
                MateriaDto materia = (MateriaDto)this.comboBox1.SelectedItem;
                await MateriaApiClient.DeleteAsync(materia.Id);
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