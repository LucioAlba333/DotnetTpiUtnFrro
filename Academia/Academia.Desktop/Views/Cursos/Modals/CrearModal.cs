using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Cursos.Modals;

public partial class CrearModal : Form
{
    
    public CrearModal()
    {
        InitializeComponent();
    }

    private async void CrearModal_Load(object sender, EventArgs e)
    {
        SetAnioActual();
        await CargaDatos();
       
    }

    private async Task CargaDatos()
    {
        try
        {
            List<MateriaDto> materias = (List<MateriaDto>)await MateriaApiClient.GetAllAsync();
            List<ComisionDto> comisions = (List<ComisionDto>)await ComisionApiClient.GetAllAsync();
            this.comboBoxMaterias.DataSource = materias;
            this.comboBoxComisiones.DataSource = comisions;
         
            this.comboBoxComisiones.ValueMember = "Id";
            this.comboBoxMaterias.ValueMember = "Id";
            this.comboBoxMaterias.DisplayMember = "Descripcion";
            this.comboBoxComisiones.DisplayMember = "Descripcion";
            this.comboBoxComisiones.SelectedIndex = -1;
            this.comboBoxMaterias.SelectedIndex = -1;

        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetAnioActual()
    {
        var anioActual = DateTime.Now.Year;
        numericUpDownAnioCalendario.Minimum = anioActual;
        numericUpDownAnioCalendario.Value = anioActual;
    }

    private async void buttonEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.comboBoxComisiones.SelectedItem is not ComisionDto comisionDto
                || this.comboBoxMaterias.SelectedItem is not MateriaDto materiaDto) return;
            CursoDto cursoDto = new CursoDto
            {
                AnioCalendario = (int)this.numericUpDownAnioCalendario.Value,
                Cupo = (int)this.numericUpDownCupo.Value,
                ComisionDescripcion = comisionDto.Descripcion,
                MateriaDescripcion = materiaDto.Descripcion,
                IdComision = comisionDto.Id,
                IdMateria = materiaDto.Id
            };
            await CursoApiClient.AddAsync(cursoDto);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox
                .Show($"Error al enviar curso: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void buttonCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}