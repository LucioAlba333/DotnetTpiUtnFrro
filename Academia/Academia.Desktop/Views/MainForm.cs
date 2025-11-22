using Academia.ApiClient;
using Academia.Desktop.Views.Alumnos;
using Academia.Desktop.Views.Comisiones;
using Academia.Desktop.Views.Cursos;
using Academia.Desktop.Views.Especialidades;
using Academia.Desktop.Views.Materias;
using Academia.Desktop.Views.Planes;
using Academia.Desktop.Views.Profesores;
namespace Academia.Desktop.Views;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private async void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var authService = AuthServiceProvider.Instance;
            await authService.LogoutAsync();
            Application.Restart();
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Error al cerrar sesión: {exception.Message}");
        }
    }

    private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<EspecialidadesForm>();

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void planesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<PlanesForm>();
    }

    private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<MateriasForm>();
    }

    private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<AlumnosForm>();
    }

    private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<ProfesoresForm>();
    }

    private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<ComisionesForm>();
    }

    private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BringToFront<CursosForm>();
    }

    private void BringToFront<T>() where T : Form, new()
    {
        foreach (var form in this.MdiChildren)
        {
            if (form is not T) continue;
            form.BringToFront();
            return;
        }

        var nuevoForm = new T
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        nuevoForm.Show();
    }
}