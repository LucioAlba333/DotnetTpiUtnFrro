using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Cursos.Modals;

public partial class EditarModal : Form
{
    private bool _estaCargando;
    public EditarModal()
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
            this._estaCargando = true;
            List<CursoDto> cursos = (List<CursoDto>) await CursoApiClient.GetAllAsync();
            List<MateriaDto> materias = (List<MateriaDto>)await MateriaApiClient.GetAllAsync();
            List<ComisionDto> comisions = (List<ComisionDto>)await ComisionApiClient.GetAllAsync();
            this.comboBoxMaterias.DataSource = materias;
            this.comboBoxComisiones.DataSource = comisions;
            this.comboBoxCursos.DataSource = cursos;

            this.comboBoxMaterias.ValueMember = "Id";
            this.comboBoxComisiones.ValueMember = "Id";
            this.comboBoxCursos.ValueMember = "Id";

            this.comboBoxMaterias.DisplayMember = "Descripcion";
            this.comboBoxComisiones.DisplayMember = "Descripcion";
            this.comboBoxCursos.DisplayMember = "Detalle";
            this.comboBoxCursos.SelectedIndex = -1;
            this.comboBoxComisiones.SelectedIndex = -1;
            this.comboBoxMaterias.SelectedIndex = -1;
            this._estaCargando = false;
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
        numericUpDownAnioCalendario.Maximum = anioActual + 1;
        numericUpDownAnioCalendario.Value = anioActual;
    }

    private async void buttonEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.comboBoxComisiones.SelectedItem is not ComisionDto comisionDto
                || this.comboBoxMaterias.SelectedItem is not MateriaDto materiaDto
                || this.comboBoxCursos.SelectedItem is not CursoDto cursoDto) return;

            cursoDto.AnioCalendario = (int) this.numericUpDownAnioCalendario.Value;
            cursoDto.Cupo = (int)this.numericUpDownCupo.Value;
            cursoDto.ComisionDescripcion = comisionDto.Descripcion;
            cursoDto.IdComision = comisionDto.Id;
            cursoDto.IdMateria = materiaDto.Id;
            cursoDto.MateriaDescripcion = materiaDto.Descripcion;
            await CursoApiClient.UpdateAsync(cursoDto);
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

    private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(this._estaCargando) return;
        if(this.comboBoxCursos.SelectedItem is not CursoDto curso) return;
        this.toolTip1.SetToolTip(comboBoxCursos,curso.Detalle);
        this.comboBoxComisiones.SelectedValue = curso.IdComision;
        this.comboBoxMaterias.SelectedValue = curso.IdMateria;
        this.numericUpDownCupo.Value = curso.Cupo;
        this.numericUpDownAnioCalendario.Value = curso.AnioCalendario;
        
    }
}