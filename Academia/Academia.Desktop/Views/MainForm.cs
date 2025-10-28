using Academia.ApiClient;
using Academia.Desktop.Views.Alumnos;
using Academia.Desktop.Views.Comisiones;
using Academia.Desktop.Views.Especialidades;
using Academia.Desktop.Views.Materias;
using Academia.Desktop.Views.Planes;
using Academia.Desktop.Views.Profesores;
using Academia.Models;
namespace Academia.Desktop.Views;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private async void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var authService = AuthServiceProvider.Instance;
        await authService.LogoutAsync();
        Application.Restart();
    }

    private void IrEspecialidades_Click(object sender, EventArgs e)
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is EspecialidadesForm)
            {
                form.BringToFront();
                return;
            }
        }
        var especialidadesForm = new EspecialidadesForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        especialidadesForm.Show();

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void espeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is PlanesForm)
            {
                form.BringToFront();
                return;
            }
        }
        var planesForm = new PlanesForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        planesForm.Show();
    }

    private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is MateriasForm)
            {
                form.BringToFront();
                return;
            }
        }
        var materiasForm = new MateriasForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        materiasForm.Show();
    }

    private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is AlumnosForm)
            {
                form.BringToFront();
                return;
            }
        }
        var alumnosForm = new AlumnosForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        alumnosForm.Show();
    }

    private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is ProfesoresForm)
            {
                form.BringToFront();
                return;
            }
        }
        var profesoresForm = new ProfesoresForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        profesoresForm.Show();
    }

    private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
    {

        foreach (Form form in this.MdiChildren)
        {
            if (form is ComisionesForm)
            {
                form.BringToFront();
                return;
            }
        }
        var comisionesForm = new ComisionesForm
        {
            MdiParent = this,
            Dock = DockStyle.Fill,
        };
        comisionesForm.Show();
    }
}