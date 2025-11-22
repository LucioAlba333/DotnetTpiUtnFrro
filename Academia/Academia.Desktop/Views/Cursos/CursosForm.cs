using Academia.ApiClient;
using Academia.Desktop.Views.Cursos.Modals;
using Academia.Dtos;

namespace Academia.Desktop.Views.Cursos;

public partial class CursosForm : Form
{
    public CursosForm()
    {
        InitializeComponent();
        this.dataGridViewCursos.AutoGenerateColumns = false;
        this.dataGridViewCursos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ID",
            HeaderText = "ID",
            Name = "ID",
        });
        this.dataGridViewCursos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MateriaDescripcion",
            HeaderText = "Materia",
            Name = "Materia",
        });
       this.dataGridViewCursos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ComisionDescripcion",
            HeaderText = "Comision",
            Name = "Comision"
        });

        this.dataGridViewCursos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "AnioCalendario",
            HeaderText = "Año",
            Name = "Año"
        });

        this.dataGridViewCursos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Cupo",
            HeaderText = "Cupo",
            Name = "Cupo"
        });
    }

    private async void CursosForm_Load(object sender, EventArgs e)
    {
        await CargaDatos();
    }

    private async Task CargaDatos()
    {
        try
        {
            List<CursoDto> cursos = (List<CursoDto>)await CursoApiClient.GetAllAsync();
            this.dataGridViewCursos.DataSource = null;
            this.dataGridViewCursos.DataSource = cursos;
            EstadoBotones(cursos);
        }
        catch (Exception e)
        {
            MessageBox.Show($"{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void EstadoBotones(List<CursoDto> cursos)
    {
        bool estaVacio = cursos.Count > 0;
        this.toolStripButtonEliminar.Enabled = estaVacio;
        this.toolStripButtonEditar.Enabled = estaVacio;
    }

    private async void buttonActualizar_Click(object sender, EventArgs e)
    {
        await CargaDatos();
    }

    private void buttonVolver_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void toolStripButtonNuevo_Click(object sender, EventArgs e)
    {
        var modal = new CrearModal();
        var crear = modal.ShowDialog();
        if (crear == DialogResult.OK)
            await CargaDatos();
    }

    private async void toolStripButtonEditar_Click(object sender, EventArgs e)
    {
        var modal = new EditarModal();
        var editar = modal.ShowDialog();
        if (editar == DialogResult.OK)
            await CargaDatos();
    }

    private async void toolStripButtonEliminar_Click(object sender, EventArgs e)
    {
        var modal = new EliminarModal();
        var eliminar = modal.ShowDialog();
        if (eliminar == DialogResult.OK)
            await CargaDatos();
    }
}