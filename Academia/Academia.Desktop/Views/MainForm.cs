using Academia.Desktop.Views.Alumnos;
using Academia.Desktop.Views.Especialidades;
using Academia.Desktop.Views.Materias;
using Academia.Desktop.Views.Planes;
using Academia.Models;
namespace Academia.Desktop.Views;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
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
            if(form is AlumnosForm)
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
        ;alumnosForm.Show();
    }
}